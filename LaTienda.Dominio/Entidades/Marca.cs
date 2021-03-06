using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Dominio
{
    public class Marca
    {
        public int MarcaID { get; set; }
        public string Descripcion { get; set; }

        public virtual List<Producto> Productos { get; set; }

        public Marca()
        {

        }

        public Marca(int marcaID, string descripcion)
        {
            MarcaID = marcaID;
            Descripcion = descripcion;
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
