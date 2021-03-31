using System.Collections.Generic;
using System.Linq;
using AP = Api.Movie.Fan.BackEnd.Core.Models;
using SEV = Client.Models.Movie;
namespace Api.Movie.Fan.BackEnd.Core.Mappers
{
    /// <summary>
    /// Mapper to map a Api model to client model.
    /// Mapper to map a client model to Api model
    /// </summary>
    public static class MovieMapper
    {
        /// <summary>
        /// Functio static to Convert an object MovieDirectorWriter from Client to API MovieDirectorWriter
        /// </summary>
        /// <param name="movie">Client MovieDirectorWriter</param>
        /// <returns>API MovieDirectorWriter</returns>
        public static AP.Movi.MovieDirectorWriter ToApi(this SEV.MovieDirectorWriter movie_W_Director_Writer)
        {
            if (movie_W_Director_Writer == null) return null;
            return new AP.Movi.MovieDirectorWriter()
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
        /// Functio static to Convert an object MovieCasting from Client to API Casting
        /// </summary>
        /// <param name="movie">Client MovieCasting</param>
        /// <returns>API Casting</returns>
        public static AP.Movi.Casting ToApi(this SEV.MovieCasting movieCasting)
        {
            if (movieCasting == null) return null;
            return new AP.Movi.Casting
            {
                Role = movieCasting.Role,
                Actor = movieCasting.Actor
            };
        }
        /// <summary>
        /// Functio static to Convert an object Movie from Client to API ShortfMovie
        /// </summary>
        /// <param name="movie">Client MovieCasting</param>
        /// <returns>API ShortfMovie</returns>
        public static AP.Movi.ShortMovie ToApi(this SEV.Movie movie)
        {
            if (movie == null) return null;
            return new AP.Movi.ShortMovie
            {
                Id = movie.Id,
                Title = movie.Title,
                Synopsis = movie.Synopsis,
                YearRelease = movie.YearRelease
            };
        }
        /// <summary>
        /// Functio static to Convert an object NewMovieForm API to Client NewMovie
        /// </summary>
        /// <param name="movie">API NewMovieForm</param>
        /// <returns>Client NewMovie</returns>
        public static SEV.NewMovie ToApi(this AP.Form.Movies.NewMovieForm newMovie)
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
        /// <summary>
        /// Functio static to Convert an object Movies API to Client Movie
        /// </summary>
        /// <param name="movie">API Movies</param>
        /// <returns>Client Movie</returns>
        public static SEV.Movie ToApi(this AP.Movi.Movies movies)
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
