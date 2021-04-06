using Api.Movie.Fan.BackEnd.Core.Mappers;
using Api.Movie.Fan.BackEnd.Core.Models.Movi;
using Client.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Api.Movie.Fan.BackEnd.Core.Models.Form.Movies;
using Swashbuckle.AspNetCore.Annotations;
using Api.Movie.Fan.BackEnd.Core.ResponseError;
using Microsoft.AspNetCore.Authorization;

namespace Api.Movie.Fan.BackEnd.Core.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        private IMovieService Service;
        /// <param name="service">IMovieService</param>
        public MovieController(IMovieService service)
        {
            Service = service;
        }

        /// <returns>IAction Result</returns>
        #region Swagger
        [SwaggerOperation("Return a list of movie")]
        [SwaggerResponse(200, "Return a list of movie", typeof(ShortMovie))]
        [SwaggerResponse(500, "Server Error")]
        #endregion
        [HttpGet]
        public IActionResult GetAll()
        {
            List<ShortMovie> movies = Service.GetAll().Select(m => m.ToApi()).ToList();
            return Ok(movies);
        }

        /// <param name="id">Int id of Movie</param>
        /// <returns></returns>
        #region Swagger
        [SwaggerOperation("Return a movie")]
        [SwaggerResponse(200, "Return a movie", typeof(ShortMovie))]
        [SwaggerResponse(500, "Server Error")]
        #endregion
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute, SwaggerParameter("Id of Movie", Required = true)] int id)
        {
            return Ok(Service.Get(id).ToApi());
        }

        /// <returns>IAction Result</returns>
        #region Swagger
        [SwaggerOperation("Return a list of movie with director and writer")]
        [SwaggerResponse(200, "Return a list of movie with Director and Writer", typeof(MovieDirectorWriter))]
        [SwaggerResponse(500, "Server Error")]
        #endregion
        [HttpGet]
        [Route("MovieDirectorWriter")]
        public IActionResult GetMovieDirectorWriter()
        {
            List<MovieDirectorWriter> movies_Director_Writer = Service.GetMovieDirectorWriter().Select(m => m.ToApi()).ToList();
            return Ok(movies_Director_Writer);
        }

        /// <param name="id">int id of movie</param>
        /// <returns>IAction Result</returns>
        #region Swagger
        [SwaggerOperation("Return on movie with Director and Writer")]
        [SwaggerResponse(200, "Return on movie with Director and Writer", typeof(MovieDirectorWriter))]
        [SwaggerResponse(500, "Server error")]
        #endregion
        [HttpGet]
        [Route("MovieDirectorWriter/{id}")]
        public IActionResult GetMovieDirectorWriter([FromRoute, SwaggerParameter("Id of Movie", Required = true)] int id)
        {
            MovieDirectorWriter movieDirectorWriter = Service.GetMovieDirectorWriter(id).ToApi();
            return Ok(movieDirectorWriter);
        }

        /// <param name="id">int id of movie casting</param>
        /// <returns>IAction Result</returns>
        #region Swagger
        [SwaggerOperation("Return one Movie with Casting")]
        [SwaggerResponse(200, "Return one Movie with Casting", typeof(MovieCasting))]
        [SwaggerResponse(500, "Server Error")]
        #endregion
        [HttpGet]
        [Route("MovieCasting/{id}")]
        public IActionResult GetMovieCasting([FromRoute, SwaggerParameter("Id of Movie", Required = true)] int id)
        {
            MovieCasting movieCasting = new MovieCasting();
            movieCasting.Movies = Service.Get(id).ToApi();
            movieCasting.Castings = Service.GetMovieCasting(id).Select(m => m.ToApi()).ToList();
            return Ok(movieCasting);
        }

        /// <param name="newMovie">NewMovieForm</param>
        /// <returns>IAction Result</returns>
        #region Swagger
        [SwaggerOperation("Create new Movie")]
        [SwaggerResponse(200, "Return a Id of Movie Created", typeof(int))]
        [SwaggerResponse(400, "Form is invalid",typeof(ExceptionResponse))]
        [SwaggerResponse(500,"Server Error")]
        #endregion
        [HttpPost]
        public IActionResult CreateNewMovie([FromBody,SwaggerRequestBody("Form New Movie",Required =true)] NewMovieForm newMovie)
        {
            try
            {
                return Ok(Service.Create(newMovie.ToApi()));
            }
            catch
            {
                return new BadRequestObjectResult(new ExceptionResponse() { Status = 400,Value = "Form is invalid" });
            }
        }
        /// <param name="movie">Movies</param>
        /// <returns>IAction Result</returns>
        #region Swagger
        [SwaggerOperation("Update a Movie")]
        [SwaggerResponse(200,"Return a boolean: True if success",typeof(bool))]
        [SwaggerResponse(400,"Form is invalid")]
        [SwaggerResponse(400, "Form is invalid", typeof(ExceptionResponse))]
        #endregion
        [HttpPut]
        public IActionResult UpdateMovie([FromBody,SwaggerRequestBody("Movie",Required =true)]Movies movie)
        {
            try
            {
                return Ok(Service.Update(movie.ToApi()));
            }
            catch
            {
                return new BadRequestObjectResult(new ExceptionResponse() { Status = 400, Value = "Form is invalid" });
            }
        }
    }
}
