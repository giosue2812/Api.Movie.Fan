using DAL_Movie.Entities;
using DAL_Movie.ModelView;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Movie.Mappers
{
    /// <summary>
    /// Mapper to map to Database to Dal
    /// </summary>
    public static class MovieMapper
    {
        /// <summary>
        /// Function to map a IDataRecord to Movie
        /// </summary>
        /// <param name="record">IDataRecord</param>
        /// <returns>Movie</returns>
        public static Movie ToMovies(this IDataRecord record)
        {
            if (record == null) return null;
            return new Movie()
            {
                Id = (int)record["IdMovie"],
                Title = (string)record["Title"],
                YearRelease = (int)record["YearRelease"],
                Synopsis = (string)record["Synopsis"],
                Director = (int)record["Director"],
                Writer = (int)record["Writer"]
            };
        }
        /// <summary>
        /// Function to map IDataRecord to MovieDirectorWriter
        /// </summary>
        /// <param name="record">IDataRecord</param>
        /// <returns>MovieDirectorWriter</returns>
        public static MovieDirectorWriter ToMovieDirectorWriter(this IDataRecord record)
        {
            if (record == null) return null;
            return new MovieDirectorWriter()
            {
                Id = (int)record["IdMovie"],
                Title = (string)record["Title"],
                YearRelease = (int)record["YearRelease"],
                Synopsis = (string)record["Synopsis"],
                Director = (string)record["Director"],
                Writer = (string)record["Writer"]
            };
        }
        /// <summary>
        /// Function to Map a IDataRecord to MovieCasting
        /// </summary>
        /// <param name="record"></param>
        /// <returns>MovieCasting</returns>
        public static MovieCasting ToMovieCasting(this IDataRecord record)
        {
            if (record == null) return null;
            return new MovieCasting()
            {
                Title = (string)record["Title"],
                Actor = (string)record["Actor"],
                Role = (string)record["Role"]
            };
        }
    }
}
