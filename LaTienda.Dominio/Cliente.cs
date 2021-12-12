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
        public long CUIT { get; set; }
        public string RazonSocial { get; set; }
        public string Domicilio { get; set; }

        public Cliente(int clienteID, long cUIT, string razonSocial, string domicilio)
        {
            ClienteID = clienteID;
            CUIT = cUIT;
            RazonSocial = razonSocial;
            Domicilio = domicilio;
        }
    }
}
