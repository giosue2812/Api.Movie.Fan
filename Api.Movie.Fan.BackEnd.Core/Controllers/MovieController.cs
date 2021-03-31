using Api.Movie.Fan.BackEnd.Core.Mappers;
using Api.Movie.Fan.BackEnd.Core.Models.Movi;
using Api.Movie.Fan.BackEnd.Core.Models.Form;
using Client.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Api.Movie.Fan.BackEnd.Core.Models.Form.Movies;

namespace Api.Movie.Fan.BackEnd.Core.Controllers
{
    /// <summary>
    /// Controller Movie
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        /// <summary>
        /// private of type IMovieService
        /// </summary>
        private IMovieService Service;
        /// <summary>
        /// Constructor of Controller wich implement a IMovieService
        /// </summary>
        /// <param name="service">IMovieService</param>
        public MovieController(IMovieService service)
        {
            Service = service;
        }
        /// <summary>
        /// Function to Get all movie
        /// </summary>
        /// <returns>IAction Result</returns>
        [HttpGet]
        public IActionResult GetAll()
        {
            List<ShortMovie> movies = Service.GetAll().Select(m => m.ToApi()).ToList();
            return Ok(movies);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(Service.Get(id).ToApi());
        }
        /// <summary>
        /// Function to Get all movie with Director and Writer
        /// </summary>
        /// <returns>IAction Result</returns>
        [HttpGet]
        [Route("MovieDirectorWriter")]
        public IActionResult GetMovieDirectorWriter()
        {
            List<MovieDirectorWriter> movies_Director_Writer = Service.GetMovieDirectorWriter().Select(m => m.ToApi()).ToList();
            return Ok(movies_Director_Writer);
        }
        /// <summary>
        /// Function to Get one movie director writer
        /// </summary>
        /// <param name="id">int id of movie</param>
        /// <returns>IAction Result</returns>
        [HttpGet]
        [Route("MovieDirectorWriter/{id}")]
        public IActionResult GetMovieDirectorWriter(int id)
        {
            MovieDirectorWriter movieDirectorWriter = Service.GetMovieDirectorWriter(id).ToApi();
            return Ok(movieDirectorWriter);
        }
        /// <summary>
        /// Function to get one movie casting
        /// </summary>
        /// <param name="id">int id of movie casting</param>
        /// <returns>IAction Result</returns>
        [HttpGet]
        [Route("MovieCasting/{id}")]
        public IActionResult GetMovieCasting(int id)
        {
            MovieCasting movieCasting = new MovieCasting();
            movieCasting.Movies = Service.Get(id).ToApi();
            movieCasting.Castings = Service.GetMovieCasting(id).Select(m => m.ToApi()).ToList();
            return Ok(movieCasting);
        }
        /// <summary>
        /// Create a new movie
        /// </summary>
        /// <param name="newMovie">NewMovieForm</param>
        /// <returns>IAction Result</returns>
        [HttpPost]
        public IActionResult CreateNewMovie(NewMovieForm newMovie)
        {
            try
            {
                return Ok(Service.Create(newMovie.ToApi()));
            }
            catch
            {
                return new BadRequestObjectResult(new {error = "Form is invalid" });
            }
        }
        /// <summary>
        /// Update a new movie
        /// </summary>
        /// <param name="movie">Movies</param>
        /// <returns>IAction Result</returns>
        [HttpPut]
        public IActionResult UpdateMovie(Movies movie)
        {
            try
            {
                return Ok(Service.Update(movie.ToApi()));
            }
            catch
            {
                return new BadRequestObjectResult(new { error = "Form is invalid" });
            }
        }
    }
}
