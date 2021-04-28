using DAL_Movie.Entities;
using DAL_Movie.ModelView.Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Movie.Repositories.Interfaces
{
    /// <summary>
    /// Interface Person Repository wich implement the IRepository
    /// </summary>
    /// <typeparam name="TEntity">Entity</typeparam>
    public interface IPersonRepository:IRepository<Person,int>
    {
        /// <summary>
        /// Funtion to get a Person Movie
        /// </summary>
        /// <param name="id">int id of Movie</param>
        /// <returns>PersonMovie</returns>
        IEnumerable<PersonMovie> GetPersonMovie(int id);
        /// <summary>
        /// Function to get a list of movie by person (Producteur or Writer)
        /// </summary>
        /// <param name="id">int id of Producteur or Writer</param>
        /// <returns>PersonProdWritMovie</returns>
        IEnumerable<PersonProdWritMovie> GetPersonProdWritMovies(int id);

        /// <summary>
        /// Function to update a Person
        /// </summary>
        /// <param name="entity">Person</param>
        /// <returns>bool: true if success</returns>
        bool Update(Person entity);
    }
}
