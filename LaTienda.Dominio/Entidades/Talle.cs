using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Dominio
{
    public class Talle
    {
        public int TalleID { get; set; }
        public string Descripcion { get; set; }

        public virtual List<Stock> Stocks { get; set; }

        public Talle()
        {

        }

        public Talle(int talleID, string descripcion)
        {
            TalleID = talleID;
            Descripcion = descripcion;
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
