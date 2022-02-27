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
        public virtual Talle Talle { get; private set; }
        public virtual Color Color { get; private set; }
        public int CantidadEnStock { get; private set; }

        public int TalleID { get; set; }
        public int ColorID { get; set; }
        public int ProductoID { get; set; }
        public virtual Producto Producto { get; set; }

        public Stock()
        {

        }

        public Stock(Talle talle, Color color, int cantidadEnStock)
        {
            Talle = talle;
            Color = color;
            CantidadEnStock = cantidadEnStock;
        }
    }
}
