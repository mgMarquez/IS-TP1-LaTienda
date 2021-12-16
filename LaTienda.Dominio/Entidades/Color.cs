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

        public Color(int colorID, string descripcion)
        {
            ColorID = colorID;
            Descripcion = descripcion;
        }
    }
}
