using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Dominio
{
    public interface IRepositorio
    {
        Empleado BuscarEmpleado(int legajo);
        Talle ObtenerTalle(int codigoTalle);
        Color ObtenerColor(int codigoColor);
        Marca ObtenerMarca(int codigoMarca);
        Rubro ObtenerRubro(int codigoRubro);
        Producto ObtenerProducto(int codigo);
        void EliminarProducto(int codigoProducto);
    }
}
