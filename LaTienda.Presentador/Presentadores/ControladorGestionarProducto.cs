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
        private readonly IRepositorio<Producto> _repositorioProducto;
        private readonly IRepositorio<Marca> _repositorioMarca;
        private readonly IRepositorio<Rubro> _repositorioRubro;
        private readonly IGestionarProductoVista _vista;
        private Producto _productoActual;

        public ControladorGestionarProducto(IRepositorio<Producto> repositorioProducto, 
            IRepositorio<Marca> repositorioMarca,
            IRepositorio<Rubro> repositorioRubro,
            IGestionarProductoVista vista)
        {
            _repositorioProducto = repositorioProducto;
            _repositorioMarca = repositorioMarca;
            _repositorioRubro = repositorioRubro;
            _vista = vista;
        }

        public void IngresarNuevoProducto(int codigo, string descripcion, double costo, 
            double porcentajeDeIVA, double margenGanancia, int codigoMarca, int codigoRubro)
        {
            var marca = _repositorioMarca.BuscarPorId(codigoMarca);
            var rubro = _repositorioRubro.BuscarPorId(codigoRubro);
            var porcentajeDeIva = ReglaDeNegocio.PorcentajeDeIVA;
            var producto = new Producto(codigo, descripcion, costo, porcentajeDeIva, 
                margenGanancia, marca, rubro);
            _repositorioProducto.Agregar(producto);
        }

        public void ModificarProducto(int productoId, int codigo, string descripcion, double costo, double porcentajeDeIva, 
            double margenGanancia, int codigoMarca, int codigoRubro)
        {
            var producto = _repositorioProducto.BuscarPorId(productoId);
            var marca = _repositorioMarca.BuscarPorId(codigoMarca);
            var rubro = _repositorioRubro.BuscarPorId(codigoRubro);
            var productoModificado = new Producto(codigo, descripcion, costo, porcentajeDeIva,
                margenGanancia, marca, rubro);
            producto.ActualizarProducto(productoModificado);
            _repositorioProducto.Modificar(producto);
        } 

        public void BuscarProducto(int codigo)
        {
            var producto = _repositorioProducto.BuscarPorId(codigo);
            _productoActual = producto;
        }


        public void EliminarProducto(int codigoProducto)
        {
            var producto = _repositorioProducto.BuscarPorId(codigoProducto);
            _repositorioProducto.Eliminar(producto);
        }

    }
}
