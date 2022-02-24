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

    }
}
