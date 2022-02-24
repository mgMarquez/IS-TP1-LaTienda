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

        public double SubTotal => Producto.PrecioDeVenta * Cantidad;
        public double NetoGravadoTotal => Producto.NetoGravado * Cantidad;
        public double IVATotal => Producto.IVA * Cantidad;

        public LineaDeVenta(Producto producto, Color color, Talle talle, int cantidad)
        {
            Producto = producto;
            Color = color;
            Talle = talle;
            Cantidad = cantidad;
        }

    }
}
