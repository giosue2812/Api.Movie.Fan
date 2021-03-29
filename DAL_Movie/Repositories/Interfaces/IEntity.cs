using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Movie.Repositories.Interfaces
{
    /// <summary>
    /// Interface Identifier for Entity
    /// </summary>
    /// <typeparam name="TKey">Key of type of identifier</typeparam>
    public interface IEntity<TKey>
    {
        TKey Id { get; set; }
    }
}
