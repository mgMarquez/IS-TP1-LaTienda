using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Dominio
{
    public interface IRepositorio<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Listar();
        int Modificar(TEntity entidad);
        int Agregar(TEntity entidad);
        int Eliminar(TEntity entidad);
        TEntity BuscarPorId(int id);
    }
}
