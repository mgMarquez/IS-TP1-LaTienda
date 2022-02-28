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
        private Venta _venta;
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
            _venta = new Venta(vendedor);
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
            _venta.AgregarProducto(_productoActual, color, talle, cantidad);
            _vista.MostrarDetalleDeVenta(_venta._detalleVenta);
        }

        public void SeleccionarCondicionTributaria(CondicionTributaria condicion)
        {
            // TODO: Generar el comprobante
        }

        public void FinalizarVenta(double importe)
        {
            if (_venta._detalleVenta == null) throw new ArgumentNullException();
        }

    }
}
