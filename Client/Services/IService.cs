using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Services
{
    /// <summary>
    /// Interface IService to get a base crud for any service
    /// </summary>
    /// <typeparam name="TEntity">Entity</typeparam>
    /// <typeparam name="Tkey">Key</typeparam>
    public interface IService<TEntity,Tkey,TBody>
    {
        /// <summary>
        /// Function to create a new Entity
        /// </summary>
        /// <typeparam name="TResult">Type of Result</typeparam>
        /// <typeparam name="TBody">Type of Body</typeparam>
        /// <param name="entity">Entity</param>
        /// <returns>Result</returns>
        int Create(TBody entity);
        /// <summary>
        /// Function to get one Entity
        /// </summary>
        /// <param name="id">Key id of entity</param>
        /// <returns>Entity</returns>
        TEntity Get(Tkey id);
        /// <summary>
        /// Function to get all entity
        /// </summary>
        /// <returns>Entity</returns>
        IEnumerable<TEntity> GetAll();
        /// <summary>
        /// Function to update an Entity
        /// </summary>
        /// <typeparam name="TResult">Type of Result</typeparam>
        /// <typeparam name="TBody">Type of Body</typeparam>
        /// <param name="entity">Entity</param>
        /// <returns>Result</returns>
        bool Update(TEntity entity);
    }
}

