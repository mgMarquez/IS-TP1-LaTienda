using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Dominio
{
    public class Venta
    {
        private readonly Empleado _empleado;
        private List<LineaDeVenta> _detalleVenta;
        public double Total => _detalleVenta.Sum(lv => lv.ObtenerSubTotal());

        public Venta(Empleado empleado)
        {
            _empleado = empleado;
            _detalleVenta = new List<LineaDeVenta>();
        }

        public void AgregarLineaDeVenta(LineaDeVenta lineaDeVenta)
        {
            _detalleVenta.Add(lineaDeVenta);
            
        }

        public void RegistrarImporteVenta(double importe, double vuelto)
        {
            // TODO: Registrar imoprte de venta
            throw new NotImplementedException();
        }
    }
}
