using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Dominio
{
    public class LineaDeVenta
    {
        public Producto Producto { get; private set; }
        public Color Color { get; private set; }
        public Talle Talle { get; private set; }
        public int Cantidad { get; set; }


        public LineaDeVenta(Producto producto, Color color, Talle talle, int cantidad)
        {
            Producto = producto;
            Color = color;
            Talle = talle;
            Cantidad = cantidad;
        }

        public double ObtenerSubTotal()
        {
            return Producto.PrecioDeVenta * Cantidad;
        }
    }
}
