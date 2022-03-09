using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Dominio
{
    public class Stock
    {
        public int StockID { get; set; }
        public virtual Talle Talle { get; set; }
        public virtual Color Color { get; set; }
        public int CantidadEnStock { get; set; }

        public int TalleID { get; set; }
        public int ColorID { get; set; }
        public int ProductoID { get; set; }
        public virtual Producto Producto { get; set; }


    }
}
