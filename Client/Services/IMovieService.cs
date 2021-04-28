using Client.Models.Movie;
using System.Collections.Generic;

namespace Client.Services
{
    /// <summary>
    /// Interface IMovieService for only Movie Service wich implement IService 
    /// </summary>
    public interface IMovieService :IService<Movie,int,NewMovie>
    {
        /// <summary>
        /// Function to get all Movie with Director and Writer
        /// </summary>
        /// <returns>MovieDirectorWriter</returns>
        IEnumerable<MovieDirectorWriter> GetMovieDirectorWriter();
        /// <summary>
        /// Function to get a Movie with Directo and Writer
        /// </summary>
        /// <param name="id">int id of Movie</param>
        /// <returns>MovieDirectorWriter</returns>
        MovieDirectorWriter GetMovieDirectorWriter(int id);
        /// <summary>
        /// Function to get a movie casting
        /// </summary>
        /// <returns>IEnumerable of MovieCasting</returns>
        IEnumerable<MovieCasting> GetMovieCasting(int id);
        /// <summary>
        /// Function to update a Movie
        /// </summary>
        /// <param name="movie">Movie</param>
        /// <returns>bool:true if sucess</returns>
        bool Update(Movie movie);
        /// <summary>
        /// Function to addCasting
        /// </summary>
        /// <param name="entity">AddCasting</param>
        /// <returns>int of created casting</returns>
        int AddCasting(AddCasting entity);
    }
}