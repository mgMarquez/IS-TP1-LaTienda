using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Dominio
{
    public class LineaDeVenta
    {
        private Producto _producto;
        private Color _color;
        private Talle _talle;
        public int Cantidad { get; set; }


        public LineaDeVenta(Producto producto, Color color, Talle talle, int cantidad)
        {
            _producto = producto;
            _color = color;
            _talle = talle;
            Cantidad = cantidad;
        }

        public double ObtenerSubTotal()
        {
            return _producto.PrecioDeVenta * Cantidad;
        }
    }
}
