using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Dominio
{
    public class Color
    {
        public int ColorID { get; set; }
        public string Descripcion { get; set; }

        public virtual List<Stock> Stocks { get; set; }

        public Color()
        {

        }

        public Color(int colorID, string descripcion)
        {
            ColorID = colorID;
            Descripcion = descripcion;
        }

        public override string ToString()
        {
            return Descripcion;
        }
    }
}
