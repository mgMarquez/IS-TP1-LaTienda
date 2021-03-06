using LaTienda.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Infraestructura.Datos
{
    public interface IUnitOfWork
    {
        IGenericRepository<Producto> ProductoRepository { get; }
        IGenericRepository<Marca> MarcaRepository { get; }
        IGenericRepository<Rubro> RubroRepository { get; }
        IGenericRepository<Stock> StockRepository { get; }
        IGenericRepository<Cliente> ClienteRepository { get; }
        IGenericRepository<Comprobante> ComprobanteRepository { get; }
        IGenericRepository<Talle> TalleRepository { get; }
        IGenericRepository<Color> ColorRepository { get; }

        void Save();
    }
}
