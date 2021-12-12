using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Dominio
{
    public class Proveedor
    {
        public int ProveedorID { get; set; }
        public string Descripcion { get; set; }

        public Proveedor(int proveedorID, string descripcion)
        {
            ProveedorID = proveedorID;
            Descripcion = descripcion;
        }
    }
}
