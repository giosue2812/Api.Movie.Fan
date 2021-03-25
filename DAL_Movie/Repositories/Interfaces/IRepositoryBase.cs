using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Movie.Repositories.Interfaces
{
    public interface IRepositoryBase<TEntity>
    {
        IEnumerable<TEntity> GetAll();
        TEntity Get(int id);
        TResult Create<TResult, TBody>(TBody entity);
        TResult Update<TResult, TBody>(TBody entity);
        TResult Delete<TResult>(int id);
    }
}
