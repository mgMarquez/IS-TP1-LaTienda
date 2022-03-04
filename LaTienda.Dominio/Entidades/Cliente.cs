using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Dominio
{
    public class Cliente
    {
        public int ClienteID { get; set; }
        public TipoDocumento TipoDocumento { get; set; } = TipoDocumento.CUIT;
        // tipoDoc 80 y NroDoc 23000000000 - no categorizado - documentación
        // no se toma en cuenta la validación del doc.
        public long NroDocumento { get; set; } = 20111111112;
        public string RazonSocial { get; set; } = "Anónimo";
        public string Domicilio { get; set; } = "Anónimo";
        public CondicionTributaria CondicionTributaria { get; set; } = CondicionTributaria.ConsumidorFinal;
    }
}
