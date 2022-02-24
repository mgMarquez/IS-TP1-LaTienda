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
        private readonly IRepositorio<Venta> _repositorioVenta;
        private readonly IRepositorio<Producto> _repositorioProducto;
        private readonly IRegistrarVentaVista _vista;
        private Producto _productoActual;
        private Vendedor _vendedor;

        public ControladorRegistrarVenta(IRepositorio<Venta> repositorio,
            IRepositorio<Producto> repositorioProducto, IRegistrarVentaVista vista)
        {
            _repositorioVenta = repositorio;
            _repositorioProducto = repositorioProducto;
            _vista = vista;
        }

        public void IniciarVenta()
        {
            _vendedor = Sesion.Empleado as Vendedor;
            _venta = new Venta(_vendedor);
        }

        public void BuscarProducto(int codigo)
        {
            _productoActual = _repositorioProducto
                .BuscarPor(p => p.Codigo == codigo)
                .First();
            _vista.MostrarProducto(_productoActual);
        }

        public void AgregarProductoVenta(Color color, Talle talle, int cantidad)
        {
            var lineaDeVenta = new LineaDeVenta(_productoActual, color, talle, cantidad);
            _venta.AgregarLineaDeVenta(lineaDeVenta);
            _vista.MostrarDetalleDeVenta(_venta._detalleVenta);
        }

        public void SeleccionarCondicionTributaria(CondicionTributaria condicion)
        {
            // TODO: Generar el comprobante
        }

        public void FinalizarVenta(double importe)
        {
            if (_vendedor == null) throw new ArgumentNullException();
            if (_venta._detalleVenta == null) throw new ArgumentNullException();

        }

    }
}
