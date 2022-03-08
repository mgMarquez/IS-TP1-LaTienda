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

        public ControladorGestionarProducto(IUnitOfWork unitOfWork, IGestionarProductoVista vista)
        {
            _unitOfWork = unitOfWork;
            _vista = vista;
        }

        public void CrearProducto(Producto productoNuevo)
        {
            _unitOfWork.ProductoRepository.Create(productoNuevo);
            _unitOfWork.Save();
        }

        public void ModificarProducto(Producto productoModificado)
        {
            _unitOfWork.ProductoRepository.Update(productoModificado);
            _unitOfWork.Save();
        }

        public void EliminarProducto(Producto producto)
        {
            EliminarProducto(producto.ProductoID);
        }

        public void EliminarProducto(int idProducto)
        {
            _unitOfWork.ProductoRepository.Delete(idProducto);
            _unitOfWork.Save();
        }

        public List<Marca> BuscarMarcasDisponibles()
        {
            return _unitOfWork.MarcaRepository.GetAll().ToList();
        }

        public List<Rubro> BuscarRubrosDisponibles()
        {
            return _unitOfWork.RubroRepository.GetAll().ToList();
        }

        public void BuscarProductos(string filtro)
        {
            var filtroMinusculas = filtro.ToLower();
            List<Producto> productos;
            if (string.IsNullOrEmpty(filtro))
            {
                productos = _unitOfWork.ProductoRepository.GetAll().ToList();
            }
            else
            {
                productos = _unitOfWork.ProductoRepository
                    .Find(c => c.Codigo.ToString().Contains(filtroMinusculas) || c.Descripcion.ToLower().Contains(filtroMinusculas)).ToList();
            }
            _vista.MostrarListaProductos(productos);
        }
    }
}
