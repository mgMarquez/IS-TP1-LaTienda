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
        void Save();
    }
}
