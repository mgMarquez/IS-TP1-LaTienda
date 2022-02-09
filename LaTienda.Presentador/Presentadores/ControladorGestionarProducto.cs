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
        private readonly IRepositorio<Producto> _persistencia;
        private readonly IGestionarProductoVista _vista;
        private Producto _productoActual;

        public ControladorGestionarProducto(IRepositorio<Producto> repositorio, IGestionarProductoVista vista)
        {
            _persistencia = repositorio;
            _vista = vista;
        }

        #region Alta producto
        public void IngresarNuevoProducto(int codigo, string descripcion,
            double costo, int codigoTalle, int codigoColor, int codigoMarca, int codigoRubro, double margenGanancia)
        {
            //var color = _persistencia.ObtenerColor(codigoColor);
            //var talle = _persistencia.ObtenerTalle(codigoTalle);
            //var marca = _persistencia.ObtenerMarca(codigoMarca);
            //var porcentajeDeIva = ReglaDeNegocio.PorcentajeDeIVA;
            //var producto = new Producto(descripcion, marca, costo, porcentajeDeIva, margenGanancia);
            //var rubro = _persistencia.ObtenerRubro(codigoRubro);
        }
        #endregion

        #region Modificar producto
        public void BuscarProducto(int codigo)
        {
            var producto = _persistencia.BuscarPorId(codigo);
            _productoActual = producto;
        }

        public void ModificarProducto(string descripcion, int codigoMarca, 
            double costo, double porcentajeIVA, double margenDeGanancia)
        {
            //var marca = _persistencia.ObtenerMarca(codigoMarca);
            //Producto productoActualizado = new Producto(descripcion, marca, costo, porcentajeIVA, margenDeGanancia);
            //_productoActual.ActualizarProducto(productoActualizado);
        }
        #endregion

        #region Eliminar producto
        public void EliminarProducto(int codigoProducto)
        {
            //_persistencia.Eliminar(codigoProducto);
        }
        #endregion
    }
}
