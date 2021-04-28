using DAL_Movie.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool.Connection.DB;

namespace DAL_Movie.Repositories
{
    /// <summary>
    /// Abstract Class to describe a RepositoryBase 
    /// </summary>
    /// <typeparam name="TEntity">TEntity Represent an entity</typeparam>
    /// <typeparam name="TKey">TKey represent a Key</typeparam>
    public abstract class RepositoryBase<TEntity, TKey> : IRepository<TEntity, TKey> where TEntity:IEntity<TKey>
    {
        /// <summary>
        /// Protected Property type Connection in get only
        /// </summary>
        protected Connection Connection { get; }
        /// <summary>
        /// Protected Property type string to represent a name of table
        /// </summary>
        public RepositoryBase()
        {
            Connection = new Connection(SqlClientFactory.Instance, "Server=DESKTOP-0E0AMEL;Initial Catalog=Movie;Integrated Security=True;");
        }
        /// <summary>
        /// Function Abstract to return a TEntiy
        /// </summary>
        /// <param name="id">TKey id</param>
        /// <returns>TEntity</returns>
        public abstract TEntity Get(TKey id);
        /// <summary>
        /// Function Abstract to return a IEnumerable of TEntity
        /// </summary>
        /// <returns>IEnumerable of Entity</returns>
        public abstract IEnumerable<TEntity> GetAll();
        /// <summary>
        /// Function Abstract to insert a new Entity
        /// </summary>
        /// <typeparam name="TResult">TResult will be returned</typeparam>
        /// <typeparam name="TBody">TBody represent a data to insert</typeparam>
        /// <param name="entity">Entity</param>
        /// <returns>TResult</returns>
        public abstract int Create(TEntity entity);

    }
}
