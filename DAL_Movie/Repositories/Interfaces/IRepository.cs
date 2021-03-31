using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Movie.Repositories.Interfaces
{
    /// <summary>
    /// Interface Repository to expose Function CRUD where Entity implement IEntity
    /// </summary>
    /// <typeparam name="TEntity">Entity</typeparam>
    /// <typeparam name="TKey">Key</typeparam>
    public interface IRepository<TEntity,TKey> where TEntity:IEntity<TKey>
    {
        /// <summary>
        /// Function to get all record
        /// </summary>
        /// <returns>IEnumerable of Entity</returns>
        IEnumerable<TEntity> GetAll();
        /// <summary>
        /// Function to get one record
        /// </summary>
        /// <param name="id">Key</param>
        /// <returns>Entity</returns>
        TEntity Get(TKey id);
        /// <summary>
        /// Function to create new Entity
        /// </summary>
        /// <param name="entity">Entity</param>
        /// <returns>Result</returns>
        int Create(TEntity entity);
    }
}
