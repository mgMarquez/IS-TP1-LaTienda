using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaTienda.Dominio;

namespace LaTienda.Presentador
{
    public interface IRegistrarVentaVista
    {
        void MostrarProductoEnStock(Producto productoEnStock);
        void MostrarStockSeleccionado(Stock stockSeleccionado);
        void MostrarTallesDisponibles(List<Talle> tallesDisponibles);
        void MostrarColoresDisponibles(List<Color> coloresDisponibles);
        void MostrarDetalleDeVenta(List<LineaDeVenta> detalleVenta);
        void MostrarCliente(Cliente cliente);
        void MostrarTotalAPagar(Venta venta);
    }
}
