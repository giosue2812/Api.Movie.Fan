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
        public static SEV.MovieDirectorWriter ToClient(this DAL.ModelView.Movie.MovieDirectorWriter entity)
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
        public static SEV.MovieCasting ToClient(this DAL.ModelView.Movie.MovieCasting entity)
        {
            if (entity == null) return null;
            return new SEV.MovieCasting()
            {
                Actor = entity.Actor,
                Role = entity.Role
            };
        }
        /// <summary>
        /// Mapping to Dal Movie from Sev.NewMovie
        /// </summary>
        /// <param name="entity">SEV.NewMovie</param>
        /// <returns>Dal Movie</returns>
        public static DAL.Entities.Movie ToDal(this SEV.NewMovie entity)
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
        /// <summary>
        /// Mapping to Dal Movie from Sev.NewMovie
        /// </summary>
        /// <param name="entity">SEV.Movie</param>
        /// <returns>Dal Movie</returns>
        public static DAL.Entities.Movie ToDal(this SEV.Movie entity)
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
        /// <summary>
        /// Mapping to map a Client AddCasting to DAL AddCasting
        /// </summary>
        /// <param name="entity">SEV AddCasting</param>
        /// <returns>DAM AddCasting</returns>
        public static DAL.ModelView.Movie.AddCasting ToDal(this SEV.AddCasting entity)
        {
            if (entity == null) return null;
            return new DAL.ModelView.Movie.AddCasting
            {
                Role = entity.Role,
                IdMovie = entity.IdMovie,
                IdPerson = entity.IdPerson
            };
        }
    }
}
