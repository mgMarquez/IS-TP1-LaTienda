using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Dominio
{
    public class ReglaDeNegocio
    {
        public static double PorcentajeDeIVA { get; set; } = 0.21;
        // limite para poder generar comprobantes anonimos
        public static double LimiteComprobanteAnonimo { get; set; } = 10000;
        public static int NroPuntoDeVenta => 2;
        public static Guid HabilitacionAFIP => new Guid("C116B5BE-3AE2-4C89-B1C7-424A4A842D48");
    }
}
