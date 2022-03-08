using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaTienda.Dominio;

namespace LaTienda.Presentador
{
    public interface IGestionarProductoVista
    {
        void MostrarListaProductos(List<Producto> productos);
    }
}
