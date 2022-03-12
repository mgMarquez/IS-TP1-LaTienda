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
        public Cliente Cliente { get; set; }
        public DateTime FechaVenta { get; private set; }
        public List<LineaDeVenta> DetalleVenta { get; private set; }
        public Comprobante Comprobante { get; private set; }
        public double Total => Math.Round(DetalleVenta.Sum(lv => lv.SubTotal), 2);
        public double NetoGravado => DetalleVenta.Sum(lv => lv.NetoGravadoTotal);
        public double IVA => DetalleVenta.Sum(lv => lv.IVATotal);
        public PuntoDeVenta PuntoDeVenta { get; set; }

        public Venta(Vendedor vendedor)
        {
            Vendedor = vendedor;
            FechaVenta = new DateTime();
            DetalleVenta = new List<LineaDeVenta>();
        }

        public void AgregarProducto(Producto producto, Color color, Talle talle, int cantidad)
        {
            if (cantidad <= 0)
                throw new ArgumentOutOfRangeException("Cantidad", "La cantidad de productos debe ser mayor a cero.");
            if (producto == null || color == null || talle == null)
                throw new Exception("Para agregar un detalle de producto se debe elegir el producto, el talle y el color");
            var lineaDeVenta = new LineaDeVenta(producto, color, talle, cantidad);
            var yaExiste = DetalleVenta
                .Find(lv => lv.Producto == producto && 
                    lv.Color == color && 
                    lv.Talle == talle);
            if (yaExiste == null)
            {
                DetalleVenta.Add(lineaDeVenta);

            }
            else
            {
                yaExiste.IncrementarCantidad(cantidad);
            }
        }
        
        public void QuitarProducto(LineaDeVenta lineaDeVenta)
        {
            //var lineaDeVenta = DetalleVenta
            //    .Find(lv => lv.Producto == producto && lv.Talle == talle && lv.Color == color);
            if (lineaDeVenta == null)
                throw new Exception("No se seleccionó ninguna linea de venta para quitar");            
            DetalleVenta.Remove(lineaDeVenta);            
        }

        public void FinalizarVenta(TipoComprobante tipoComprobante)
        {
            FechaVenta = DateTime.Now;
            Comprobante = GenerarComprobate(tipoComprobante);
        }

        private Comprobante GenerarComprobate(TipoComprobante tipoComprobante)
        {
            return new Comprobante()
            {
                Fecha = FechaVenta,
                HabilitacionPDV = PuntoDeVenta.HabilitacionAFIP,
                NumeroPDV = PuntoDeVenta.NumeroPDV,
                TipoComprobante = tipoComprobante,
                DocumentoTipoCliente = Cliente.TipoDocumento,
                NumeroDocumentoCliente = Cliente.NroDocumento,
                ImporteTotal = Total,
                ImpTotConc = 0, // neto no gravado - el importe total de los productos sin IVA
                ImpNeto = NetoGravado, // importe neto gravado
                ImpOpEx = 0, // importe excento
                ImpIVA = IVA,
                ImpTrib = 0 // Suma de los importes del array de tributos
            };
        }
    }
}
