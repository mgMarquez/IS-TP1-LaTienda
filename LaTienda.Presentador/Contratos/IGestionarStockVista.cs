using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaTienda.Dominio;

namespace LaTienda.Presentador
{
    public interface IGestionarStockVista
    {
        void MostrarListaStocks(List<Stock> stocks);
    }
}
