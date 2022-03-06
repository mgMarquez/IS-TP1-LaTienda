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
        public TipoDocumento TipoDocumento { get; set; } 
        public long NroDocumento { get; set; }
        public string RazonSocial { get; set; }
        public string Domicilio { get; set; }
        public CondicionTributaria CondicionTributaria { get; set; }
    }
}
