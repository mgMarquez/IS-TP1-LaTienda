using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Dominio
{
    public class Venta
    {
        public Vendedor _vendedor { get; private set; }
        public DateTime FechaVenta { get; private set; }
        public List<LineaDeVenta> _detalleVenta { get; private set; }
        public Comprobante Comprobante { get; private set; }
        public double Total => _detalleVenta.Sum(lv => lv.SubTotal);
        public double NetoGravado => _detalleVenta.Sum(lv => lv.NetoGravadoTotal);
        public double IVA => _detalleVenta.Sum(lv => lv.IVATotal);

        public Venta(Vendedor vendedor)
        {
            _vendedor = vendedor;
            _detalleVenta = new List<LineaDeVenta>();
        }

        public void AgregarProducto(Producto producto, Color color, Talle talle, int cantidad)
        {
            var lineaDeVenta = new LineaDeVenta(producto, color, talle, cantidad);
            _detalleVenta.Add(lineaDeVenta);            
        }
        
        public void QuitarProducto(Producto producto, Color color, Talle talle)
        {
            var lineaDeVenta = _detalleVenta
                .Find(lv => lv.Producto == producto && lv.Talle == talle && lv.Color == color);
            if(lineaDeVenta != null)
            {
                _detalleVenta.Remove(lineaDeVenta);
            }
        }

        public void FinalizarVenta()
        {
            FechaVenta = new DateTime();
        }

    }
}
