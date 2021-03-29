using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL = DAL_Movie;
using SEV = Client.Models.Movie;

namespace Client.Mappers
{
    /// <summary>
    /// Mapper to Map a model Movie from service to Dal Model movie
    /// </summary>
    public static class MapperMovie
    {
        /// <summary>
        /// Mapping to map a Movie to Dal Movie
        /// </summary>
        /// <param name="entity">Movie</param>
        /// <returns>Movie model service</returns>
        public static SEV.Movie ToClient(this DAL.Entities.Movie entity)
        {
            if (entity == null) return null;
            return new SEV.Movie()
            {
                Id = entity.Id,
                Title = entity.Title,
                YearRelease = entity.YearRelease,
                Synopsis = entity.Synopsis
            };
        }
        /// <summary>
        /// Mapping to map Movie with Director and Writer to DAL Movie Director and Writer
        /// </summary>
        /// <param name="entity">MovieDirectorWriter</param>
        /// <returns>MovieDirectorWriter model service</returns>
        public static SEV.MovieDirectorWriter ToMovieDirectorWriter(this DAL.ModelView.MovieDirectorWriter entity)
        {
            if (entity == null) return null;
            return new SEV.MovieDirectorWriter()
            {
                Id = entity.Id,
                Title = entity.Title,
                Synopsis = entity.Synopsis,
                YearRelease = entity.YearRelease,
                Director = entity.Director,
                Writer = entity.Writer
            };
        }
        /// <summary>
        /// Mapping to map Movie with Casting to DAM Movie with Casting
        /// </summary>
        /// <param name="entity">MovieCasting</param>
        /// <returns>MovieCasting model service</returns>
        public static SEV.MovieCasting ToMovieCasting(this DAL.ModelView.MovieCasting entity)
        {
            if (entity == null) return null;
            return new SEV.MovieCasting()
            {
                Title = entity.Title,
                Actor = entity.Actor,
                Role = entity.Role
            };
        }
        public static DAL.Entities.Movie ToDalMovie(this SEV.NewMovie entity)
        {
            if (entity == null) return null;
            return new DAL.Entities.Movie()
            {
                Title = entity.Title,
                Director = entity.Director,
                Synopsis = entity.Synopsis,
                Writer = entity.Writer,
                YearRelease = entity.YearRelease
            };
        }
        public static DAL.Entities.Movie ToDalMovie(this SEV.Movie entity)
        {
            if (entity == null) return null;
            return new DAL.Entities.Movie()
            {
                Id = entity.Id,
                Title = entity.Title,
                Synopsis = entity.Synopsis,
                YearRelease = entity.YearRelease,
                Director = entity.Director,
                Writer = entity.Writer
            };
        }
    }
}
