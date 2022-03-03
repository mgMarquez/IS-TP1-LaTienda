using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Dominio
{
    public class Comprobante
    {
        public int ComprobanteID { get; set; }
        public int NumeroDeComprobante { get; set; }
        public TipoDocumento DocumentoTipoCliente { get; set; }
        public long NumeroDocumentoCliente { get; set; }
        public DateTime Fecha { get; set; }
        public double ImporteTotal { get; set; } // Importe total
        public double ImpTotConc { get; set; } // Importe neto no gravado
        public double ImpNeto { get; set; } // Importe neto gravado
        public double ImpOpEx { get; set; } // Importe exento
        public double ImpIVA { get; set; } // Suma de los importes del array de IVA
        public double ImpTrib { get; set; } // Suma de los importes del array de tributos
        public string CAE { get; set; }
        public int NumeroPDV { get; set; }
        public Guid HabilitacionPDV { get; set; }
        public TipoComprobante TipoComprobante { get; set; }

        public void AsignarNumeroComprobante(int ultimoNumeroComprobante)
        {
            NumeroDeComprobante = ultimoNumeroComprobante + 1;
        }

        public string FechaString => Fecha.ToString("yyyyMMdd");
    }
}
