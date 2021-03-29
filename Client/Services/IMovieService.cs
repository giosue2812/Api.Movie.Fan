using Client.Models.Movie;
using System.Collections.Generic;

namespace Client.Services
{
    /// <summary>
    /// Interface IMovieService for only Movie Service wich implement IService of movie with key int
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
        /// <returns></returns>
        MovieDirectorWriter GetMovieDirectorWriter(int id);
        /// <summary>
        /// Function to get all movie casting
        /// </summary>
        /// <returns>IEnumerable of MovieCasting</returns>
        IEnumerable<MovieCasting> GetMovieCasting();
        /// <summary>
        /// Function to get a movie casting
        /// </summary>
        /// <returns>IEnumerable of MovieCasting</returns>
        IEnumerable<MovieCasting> GetMovieCasting(int id);
    }
}