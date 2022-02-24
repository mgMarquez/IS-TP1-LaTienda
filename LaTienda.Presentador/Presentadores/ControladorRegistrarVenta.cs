using LaTienda.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Presentador
{
    public class ControladorRegistrarVenta
    {
        private Venta _venta;
        private readonly IRepositorio<Venta> _repositorio;
        private readonly IRegistrarVentaVista _vista;
        private Empleado empleado;

        public ControladorRegistrarVenta(IRepositorio<Venta> repositorio, IRegistrarVentaVista vista)
        {
            _repositorio = repositorio;
            _vista = vista;
        }

        public void IniciarVenta()
        {
            empleado = Sesion.Empleado;
            _venta = new Venta(empleado);
        }

        public void IngresarProducto(int codigo)
        {
            //var producto = _repositorio.ObtenerProducto(codigo);
            //_productoActual = producto;
        }

        public void SeleccionarDetalleProducto(int codigoColor, int codigoTalle, int cantidad)
        {
            //var color = _repositorio.ObtenerColor(codigoColor);
            //var talle = _repositorio.ObtenerTalle(codigoTalle);
            //var lineaDeVenta = new LineaDeVenta(_productoActual, color, talle, cantidad);
            //_venta.AgregarLineaDeVenta(lineaDeVenta);
            // TODO: Stock - actualizarStock - Paso 5
        }

        public void SeleccionarCondicionTributaria(CondicionTributaria condicion)
        {
            // TODO: Generar el comprobante
        }

        public void IngresarImporte(double importe)
        {
            var vuelto = CalcularVuelto(importe);
            _venta.RegistrarImporteVenta(importe, vuelto);

        }

        public void FinalizarVenta()
        {
            // TODO: Registrar venta
        }

        private double CalcularVuelto(double importe)
        {
            return 0;
        }
    }
}
