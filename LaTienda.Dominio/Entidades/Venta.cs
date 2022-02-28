using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Dominio
{
    public class Venta
    {
        public Vendedor Vendedor { get; private set; }
        public DateTime FechaVenta { get; private set; }
        public List<LineaDeVenta> DetalleVenta { get; private set; }
        public Comprobante Comprobante { get; private set; }
        public double Total => DetalleVenta.Sum(lv => lv.SubTotal);
        public double NetoGravado => DetalleVenta.Sum(lv => lv.NetoGravadoTotal);
        public double IVA => DetalleVenta.Sum(lv => lv.IVATotal);

        public Venta(Vendedor vendedor)
        {
            Vendedor = vendedor;
            DetalleVenta = new List<LineaDeVenta>();
        }

        public void AgregarProducto(Producto producto, Color color, Talle talle, int cantidad)
        {
            var lineaDeVenta = new LineaDeVenta(producto, color, talle, cantidad);
            DetalleVenta.Add(lineaDeVenta);            
        }
        
        public void QuitarProducto(Producto producto, Color color, Talle talle)
        {
            var lineaDeVenta = DetalleVenta
                .Find(lv => lv.Producto == producto && lv.Talle == talle && lv.Color == color);
            if(lineaDeVenta != null)
            {
                DetalleVenta.Remove(lineaDeVenta);
            }
        }

        public void FinalizarVenta()
        {
            FechaVenta = new DateTime();
        }

    }
}
