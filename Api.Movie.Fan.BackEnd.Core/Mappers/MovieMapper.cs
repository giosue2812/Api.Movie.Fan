using System.Collections.Generic;
using System.Linq;
using AP = Api.Movie.Fan.BackEnd.Core.Models;
using SEV = Client.Models.Movie;
namespace Api.Movie.Fan.BackEnd.Core.Mappers
{
    /// <summary>
    /// Mapper to map a Api model to service model.
    /// Mapper to map a service model to Api model
    /// </summary>
    public static class MovieMapper
    {
        /// <summary>
        /// function static To map an API movie to service movie model
        /// </summary>
        /// <param name="movie">Movie from service</param>
        /// <returns>Movie from API</returns>
        public static AP.Movies ToApiModel(this SEV.Movie movie)
        {
            if (movie == null) return null;
            return new AP.Movies()
            {
                Id = movie.Id,
                Synopsis = movie.Synopsis,
                Title = movie.Title,
                YearRelease = movie.YearRelease
            };
        }
        /// <summary>
        /// function static To map an API movie with director and writer to service movie with director and write
        /// </summary>
        /// <param name="movie">MovieDirectorWriter from service</param>
        /// <returns>MovieDirectorWriter from API</returns>
        public static AP.MovieDirectorWriter ToApiMovieDirectorWriter(this SEV.MovieDirectorWriter movie_W_Director_Writer)
        {
            if (movie_W_Director_Writer == null) return null;
            return new AP.MovieDirectorWriter()
            {
                Id = movie_W_Director_Writer.Id,
                Title = movie_W_Director_Writer.Title,
                Synopsis = movie_W_Director_Writer.Synopsis,
                YearRelease = movie_W_Director_Writer.YearRelease,
                Director = movie_W_Director_Writer.Director,
                Writer = movie_W_Director_Writer.Writer
            };
        }
        /// <summary>
        /// function static To map an API movie casting to service movie casting
        /// </summary>
        /// <param name="movie">MovieCasting from service</param>
        /// <returns>MovieCasting from API</returns>
        public static AP.MovieCasting ToApiMoviCasting(this SEV.MovieCasting movie_Casting)
        {
            if (movie_Casting == null) return null;
            return new AP.MovieCasting()
            {
                Title = movie_Casting.Title,
                Actor = movie_Casting.Actor,
                Role = movie_Casting.Role,
            };
        }
        public static SEV.NewMovie ToClientMovie(this AP.Form.NewMovieForm newMovie)
        {
            if (newMovie == null) return null;
            return new SEV.NewMovie()
            {
                Title = newMovie.Title,
                Synopsis = newMovie.Synopsis,
                Director = newMovie.Director,
                Writer = newMovie.Writer,
                YearRelease = newMovie.YearRelease
            };
        }
        public static SEV.Movie ToClientMovie(this AP.Movies movies)
        {
            if (movies == null) return null;
            return new SEV.Movie()
            {
                Id = movies.Id,
                Title = movies.Title,
                Synopsis = movies.Synopsis,
                YearRelease = movies.YearRelease,
                Director = movies.Director,
                Writer = movies.Writer
            };
        }
    }
}
