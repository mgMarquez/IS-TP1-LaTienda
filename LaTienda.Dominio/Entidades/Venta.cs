using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Dominio
{
    public class Venta
    {
        public Empleado _empleado { get; private set; }
        public DateTime FechaVenta { get; private set; }
        public List<LineaDeVenta> _detalleVenta { get; private set; }
        public Comprobante Comprobante { get; private set; }
        public double Total => _detalleVenta.Sum(lv => lv.SubTotal);
        public double NetoGravado => _detalleVenta.Sum(lv => lv.NetoGravadoTotal);
        public double IVA => _detalleVenta.Sum(lv => lv.IVATotal);

        public Venta(Empleado empleado)
        {
            _empleado = empleado;
            _detalleVenta = new List<LineaDeVenta>();
        }

        public void AgregarLineaDeVenta(LineaDeVenta lineaDeVenta)
        {
            _detalleVenta.Add(lineaDeVenta);            
        }        

        public void FinalizarVenta()
        {
            FechaVenta = new DateTime();
        }


    }
}
