using LaTienda.Dominio;
using LaTienda.Infraestructura.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Presentador
{
    public class ControladorGestionarProducto
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IGestionarProductoVista _vista;
        private Producto _productoActual;

        public ControladorGestionarProducto(IUnitOfWork unitOfWork, IGestionarProductoVista vista)
        {
            _unitOfWork = unitOfWork;
            _vista = vista;
        }

        public void IngresarNuevoProducto(int codigo, string descripcion, double costo,
            double porcentajeDeIVA, double margenGanancia, int codigoMarca, int codigoRubro)
        {
            var marca = _unitOfWork.MarcaRepository.GetById(codigoMarca);
            var rubro = _unitOfWork.RubroRepository.GetById(codigoRubro);
            var porcentajeDeIva = ReglaDeNegocio.PorcentajeDeIVA;
            var producto = new Producto()
            {
                Codigo = codigo,
                Descripcion = descripcion,
                Costo = costo,
                PorcentajeDeIva = porcentajeDeIva,
                MargenDeGanancia = margenGanancia,
                Marca = marca,
                Rubro = rubro
            };
            _unitOfWork.ProductoRepository.Create(producto);
            _unitOfWork.Save();
        }

        public void ModificarProducto(int productoId, int codigo, string descripcion, double costo, double porcentajeDeIva,
            double margenGanancia, int codigoMarca, int codigoRubro)
        {
            var producto = _unitOfWork.ProductoRepository.GetById(productoId);
            var marca = _unitOfWork.MarcaRepository.GetById(codigoMarca);
            var rubro = _unitOfWork.RubroRepository.GetById(codigoRubro);
            var productoModificado = new Producto()
            {
                Codigo = codigo,
                Descripcion = descripcion,
                Costo = costo,
                PorcentajeDeIva = porcentajeDeIva,
                MargenDeGanancia = margenGanancia,
                Marca = marca,
                Rubro = rubro
            };
            producto.ActualizarProducto(productoModificado);
            _unitOfWork.ProductoRepository.Update(producto);
            _unitOfWork.Save();
        }

        public void BuscarProducto(int codigo)
        {
            var producto = _unitOfWork.ProductoRepository.GetById(codigo);
            _productoActual = producto;
        }


        public void EliminarProducto(int codigoProducto)
        {
            var producto = _unitOfWork.ProductoRepository.GetById(codigoProducto);
            _unitOfWork.ProductoRepository.Delete(producto);
        }

    }
}
