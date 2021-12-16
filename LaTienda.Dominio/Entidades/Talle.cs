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

        public Talle(int talleID, string descripcion)
        {
            TalleID = talleID;
            Descripcion = descripcion;
        }
    }
}
