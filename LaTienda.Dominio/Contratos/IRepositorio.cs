using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LaTienda.Dominio
{
    public interface IRepositorio<TEntity> where TEntity : class
    {
        IEnumerable<TEntity> Listar();
        int Actualizar(TEntity entidad);
        int Agregar(TEntity entidad);
        int Eliminar(int id);
        int Eliminar(TEntity entidad);
        TEntity BuscarPorId(int id);
        IEnumerable<TEntity> BuscarPor(Expression<Func<TEntity, bool>> filter);
    }
}
