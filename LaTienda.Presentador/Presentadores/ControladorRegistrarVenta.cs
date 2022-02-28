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
            _ventaActual = new Venta(vendedor);
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
                .FirstOrDefault(s => _talleSeleccionado.TalleID  == s.TalleID &&
                    s.ColorID == color.ColorID);
            _vista.MostrarStockSeleccionado(_stockSeleccionado);
        }

        public void AgregarProductoVenta(Color color, Talle talle, int cantidad)
        {            
            _ventaActual.AgregarProducto(_productoActual, color, talle, cantidad);
            _vista.MostrarDetalleDeVenta(_ventaActual.DetalleVenta);

            var total = _ventaActual.Total;
            var netoGravado = _ventaActual.NetoGravado;
            var iva = _ventaActual.IVA;
            _vista.MostrarTotalAPagar(total, iva, netoGravado);
        }

        public void SeleccionarCondicionTributaria(CondicionTributaria condicion)
        {
            // TODO: Generar el comprobante
        }

        public void FinalizarVenta(double importe)
        {
            if (_ventaActual.DetalleVenta == null) throw new ArgumentNullException();
        }

    }
}
