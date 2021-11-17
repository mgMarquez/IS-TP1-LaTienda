using LaTienda.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Presentador
{
    public class ControladorGestionarProducto
    {
        private readonly IRepositorio _persistencia;
        private readonly IGestionarProductoVista _vista;
        private Producto _productoActual;

        public ControladorGestionarProducto(IRepositorio repositorio, IGestionarProductoVista vista)
        {
            _persistencia = repositorio;
            _vista = vista;
        }

        #region Alta producto
        public void IngresarNuevoProducto(int codigo, string descripcion,
            double costo, int codigoTalle, int codigoColor, int codigoMarca, int codigoRubro, double margenGanancia)
        {
            var color = _persistencia.ObtenerColor(codigoColor);
            var talle = _persistencia.ObtenerTalle(codigoTalle);
            var marca = _persistencia.ObtenerMarca(codigoMarca);
            var porcentajeDeIva = ReglaDeNegocio.PorcentajeDeIVA;
            var producto = new Producto(descripcion, color, talle, 
                marca, costo, porcentajeDeIva, margenGanancia);
            var rubro = _persistencia.ObtenerRubro(codigoRubro);
            rubro.AgregarProducto(producto);
        }
        #endregion

        #region Modificar producto
        public void BuscarProducto(int codigo)
        {
            var producto = _persistencia.ObtenerProducto(codigo);
            _productoActual = producto;
        }

        public void ModificarProducto(string descripcion, int codigoMarca, int codigoRubro, 
            int codigoColor, int codigoTalle, double costo, double margenDeGanancia)
        {
            var color = _persistencia.ObtenerColor(codigoColor);
            var talle = _persistencia.ObtenerTalle(codigoTalle);
            var marca = _persistencia.ObtenerMarca(codigoMarca);
            var rubro = _persistencia.ObtenerRubro(codigoRubro);
            _productoActual.ActualizarProducto(descripcion, marca, color, talle, costo, margenDeGanancia);
            rubro.AgregarProducto(_productoActual);
        }
        #endregion

        #region Eliminar producto
        public void EliminarProducto(int codigoProducto)
        {
            _persistencia.EliminarProducto(codigoProducto);
        }
        #endregion
    }
}
