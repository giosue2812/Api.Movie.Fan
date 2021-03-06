using DAL_Movie.Entities;
using DAL_Movie.ModelView.Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Movie.Repositories.Interfaces
{
    /// <summary>
    /// Interface Movie Repository wich implement the IRepository where Entity implement also IEntity
    /// </summary>
    /// <typeparam name="TEntity">Entity</typeparam>
    public interface IMovieRepository : IRepository<Movie, int>
    {
        /// <summary>
        /// Function to return an IEnumerable of MovieDirectorWriter
        /// </summary>
        /// <returns>IEnumerable of MovieDirectorWriter</returns>
        IEnumerable<MovieDirectorWriter> GetMovieDirectorWriter();
        /// <summary>
        /// Function to return one Movie with of Director and Writer
        /// </summary>
        /// <param name="id">int id of movie</param>
        /// <returns>MovieDirectorWriter</returns>
        MovieDirectorWriter GetMovieDirectorWriter(int id);
        /// <summary>
        /// Function to return an IEnumerable of MovieCasting of one movie
        /// </summary>
        /// <returns>IEnumerable of MovieCasting</returns>
        IEnumerable<MovieCasting> GetMovieCasting(int id);
        /// <summary>
        /// Function to update a Movie
        /// </summary>
        /// <param name="entity">Movie</param>
        /// <returns>bool: true if success</returns>
        bool Update(Movie entity);
        /// <summary>
        /// Function to add casting
        /// </summary>
        /// <param name="entity">AddCasting</param>
        /// <returns>int of casting create</returns>
        int AddCasting(AddCasting entity);
    }
}
