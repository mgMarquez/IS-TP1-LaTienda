using LaTienda.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Presentador
{
    public interface IStockVista
    {
        void MostrarProductos(List<Producto> productos);
        void MostrarTalles(List<Talle> talles);
        void MostrarColores(List<Color> colores);
        void MostrarStock(Stock stock);
        void VistaCrear();
        void VistaEliminar();
        void VistaModificar();
    }
}
