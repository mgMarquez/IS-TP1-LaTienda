using LaTienda.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Presentador
{
    public interface IProductoVista
    {
        void MostrarProducto(Producto producto);
        void MostrarMarcas(List<Marca> marcas);
        void MostrarRubros(List<Rubro> rubros);
        void VistaCrear();
        void VistaEliminar();
        void VistaModificar();
    }
}
