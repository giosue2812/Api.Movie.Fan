using Api.Movie.Fan.BackEnd.Core.Mappers;
using Api.Movie.Fan.BackEnd.Core.Models;
using Api.Movie.Fan.BackEnd.Core.Models.Form;
using Client.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

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
        /// private variable of type IMovieService
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
            List<Movies> movies = Service.GetAll().Select(m => m.ToApiModel()).ToList();
            return Ok(movies);
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(Service.Get(id).ToApiModel());
        }
        /// <summary>
        /// Function to Get all movie with Director and Writer
        /// </summary>
        /// <returns>IAction Result</returns>
        [HttpGet]
        [Route("MovieDirectorWriter")]
        public IActionResult GetMovieDirectorWriter()
        {
            List<MovieDirectorWriter> movies_Director_Writer = Service.GetMovieDirectorWriter().Select(m => m.ToApiMovieDirectorWriter()).ToList();
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
            MovieDirectorWriter movieDirectorWriter = Service.GetMovieDirectorWriter(id).ToApiMovieDirectorWriter();
            return Ok(movieDirectorWriter);
        }
        /// <summary>
        /// Function to get all movie casting
        /// </summary>
        /// <returns>IAction Result</returns>
        [HttpGet]
        [Route("MovieCasting")]
        public IActionResult GetMovieCasting()
        {
            List<MovieCasting> movieCastings = Service.GetMovieCasting().Select(m => m.ToApiMoviCasting()).ToList();
            return Ok(movieCastings);
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
            List<MovieCasting> moviesCastings = Service.GetMovieCasting(id).Select(m => m.ToApiMoviCasting()).ToList();
            return Ok(moviesCastings);
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
                return Ok(Service.Create(newMovie.ToClientMovie()));
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
                return Ok(Service.Update(movie.ToClientMovie()));
            }
            catch
            {
                return new BadRequestObjectResult(new { error = "Form is invalid" });
            }
        }
    }
}
