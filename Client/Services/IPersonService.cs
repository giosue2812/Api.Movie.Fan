using Client.Models.Persons;
using System.Collections.Generic;

namespace Client.Services
{
    /// <summary>
    /// Interface IPersonService for only Person Service wich implement IService
    /// </summary>
    public interface IPersonService: IService<Person,int,NewPerson>
    {
        /// <summary>
        /// Function to get a Person with movie and role
        /// </summary>
        /// <param name="id">int id of Person</param>
        /// <returns>PersonMovie</returns>
        IEnumerable<PersonMovie> GetPersonMovie(int id);
        /// <summary>
        /// Function to get a list of movie by person (Product or Writer)
        /// </summary>
        /// <param name="id">int id of person</param>
        /// <returns>PersonProdWritMovie</returns>
        IEnumerable<PersonProdWritMovie> GetPersonProdWritMovies(int id);

        /// <summary>
        /// Function to update a Movie
        /// </summary>
        /// <param name="movie">Movie</param>
        /// <returns>bool:true if sucess</returns>
        bool Update(Person entity);
    }
}