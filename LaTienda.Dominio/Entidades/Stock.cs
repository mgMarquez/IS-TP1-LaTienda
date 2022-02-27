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
        public Talle Talle { get; private set; }
        public Color Color { get; private set; }
        public int CantidadEnStock { get; private set; }

        public Stock(Talle talle, Color color, int cantidadEnStock)
        {
            Talle = talle;
            Color = color;
            CantidadEnStock = cantidadEnStock;
        }
    }
}
