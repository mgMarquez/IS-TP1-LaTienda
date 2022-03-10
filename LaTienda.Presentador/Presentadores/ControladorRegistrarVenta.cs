using LaTienda.Dominio;
using LaTienda.Infraestructura.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Presentador
{
    public class ControladorRegistrarVenta
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IRegistrarVentaVista _vista;
        private Venta _ventaActual;
        private Producto _productoActual;
        private Talle _talleSeleccionado;
        private Stock _stockSeleccionado;

        public ControladorRegistrarVenta(IUnitOfWork unitOfWork, IRegistrarVentaVista vista)
        {
            _unitOfWork = unitOfWork;
            _vista = vista;
        }

        public void IniciarVenta()
        {
            var vendedor = Sesion.Empleado as Vendedor;
            _ventaActual = new Venta(vendedor)
            {
                Cliente = new Cliente()
                {
                    TipoDocumento = TipoDocumento.Otro,
                    RazonSocial = "Anónimo",
                    Domicilio = string.Empty,
                    CondicionTributaria = CondicionTributaria.ConsumidorFinal
                },
                PuntoDeVenta = new PuntoDeVenta()
                {
                    NumeroPDV = ReglaDeNegocio.NroPuntoDeVenta,
                    HabilitacionAFIP = ReglaDeNegocio.HabilitacionAFIP
                }
            };
        }

        public void BuscarProducto(int codigo)
        {
            _productoActual = _unitOfWork
                .ProductoRepository
                .Find(producto => producto.Codigo == codigo)
                .First();
            _vista.MostrarProductoEnStock(_productoActual);
            var tallesDisponibles = _productoActual
                .DetalleDeStock
                .Select(s => s.Talle)
                .Distinct()
                .ToList();
            _vista.MostrarTallesDisponibles(tallesDisponibles);
        }

        public void SeleccionarTalle(Talle talle)
        {
            var coloresDisponibles = _productoActual
                .DetalleDeStock
                .Where(s => s.TalleID == talle.TalleID)
                .Select(s => s.Color)
                .Distinct()
                .ToList();
            _talleSeleccionado = talle;
            _vista.MostrarColoresDisponibles(coloresDisponibles);
        }

        public void SeleccionarColor(Color color)
        {
            _stockSeleccionado = _productoActual
                .DetalleDeStock
                .FirstOrDefault(s => _talleSeleccionado.TalleID == s.TalleID &&
                    s.ColorID == color.ColorID);
            _vista.MostrarStockSeleccionado(_stockSeleccionado);
        }

        public void AgregarProductoVenta(Color color, Talle talle, int cantidad)
        {
            try
            {

                _ventaActual.AgregarProducto(_productoActual, color, talle, cantidad);
                _vista.MostrarDetalleDeVenta(_ventaActual.DetalleVenta);

                var total = _ventaActual.Total;
                var netoGravado = _ventaActual.NetoGravado;
                var iva = _ventaActual.IVA;
                _vista.MostrarTotalAPagar(_ventaActual);
            }
            catch (Exception ex)
            {
                _vista.MensajeInformativo(ex.Message);
            }
        }

        public void FinalizarVenta()
        {

            try
            {
                if (_ventaActual.DetalleVenta == null) throw new ArgumentNullException();
                GenerarComprobante();
                ServicioAFIP.SolicitarAutorizacionComprobante(_ventaActual.Comprobante);
                if (_ventaActual.Comprobante.CAE == "") throw new Exception("El CAE no puede ser vacio, la generación del CAE fue rechazada o no se puede comunicar con el sistema de AFIP");
                _unitOfWork.ComprobanteRepository.Create(_ventaActual.Comprobante);
                _unitOfWork.Save();
            }
            catch (Exception ex)
            {
                _vista.MensajeInformativo(ex.Message);
            }

        }

        public void GenerarComprobante()
        {
            var limite = ReglaDeNegocio.LimiteComprobanteAnonimo;
            if (_ventaActual.Total > limite)
            {
                _ventaActual.FinalizarVenta(TipoComprobante.FacturaA);
            }
            else
            {
                switch (_ventaActual.Cliente.CondicionTributaria)
                {
                    case CondicionTributaria.ResponsableInscripto:
                    case CondicionTributaria.Monotributo:
                        _ventaActual.FinalizarVenta(TipoComprobante.FacturaA);
                        break;
                    case CondicionTributaria.Exento:
                    case CondicionTributaria.NoResponsable:
                    case CondicionTributaria.ConsumidorFinal:
                    default:
                        _ventaActual.FinalizarVenta(TipoComprobante.FacturaB);
                        break;
                }

            }
        }

        public void QuitarLineaDeVenta(LineaDeVenta lineaDeVentaSeleccionada)
        {
            try
            {
                _ventaActual.QuitarProducto(lineaDeVentaSeleccionada);
                _vista.MostrarDetalleDeVenta(_ventaActual.DetalleVenta);
            }
            catch (Exception ex)
            {
                _vista.MensajeInformativo(ex.Message);
            }

        }

        public void MostrarCliente()
        {
            _vista.MostrarCliente(_ventaActual.Cliente);
        }

        public void AsignarClienteVenta(long nroDocumento)
        {
            try
            {
                Cliente cliente = _unitOfWork.ClienteRepository
                        .Find(c => c.NroDocumento == nroDocumento)
                        .FirstOrDefault();
                _ventaActual.Cliente = cliente ?? throw new Exception("No se econtró un cliente con ese numero de documento");
                MostrarCliente();
            }
            catch (Exception ex)
            {
                _vista.MensajeInformativo(ex.Message);
            }
        }
    }
}
