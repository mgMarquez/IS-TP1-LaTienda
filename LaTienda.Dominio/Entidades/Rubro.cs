﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Dominio
{
    public class Rubro
    {
        public int RubroID { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Producto> Productos { get; set; }

        public Rubro(int rubroID, string descripcion)
        {
            RubroID = rubroID;
            Descripcion = descripcion;
        }
    }
}
