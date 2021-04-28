using Client.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Api.Movie.Fan.BackEnd.Core.Mappers;
using Api.Movie.Fan.BackEnd.Core.Models.Form.Persons;
using Api.Movie.Fan.BackEnd.Core.Models.Persons;
using Api.Movie.Fan.BackEnd.Core.Models.Movi;
using Swashbuckle.AspNetCore.Annotations;
using Api.Movie.Fan.BackEnd.Core.ResponseError;

namespace Api.Movie.Fan.BackEnd.Core.Controllers
{
    /// <summary>
    /// Controller Person
    /// </summary>
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IPersonService Service;
        /// <summary>
        /// Constructor of Controller wich implement a IPersonService
        /// </summary>
        /// <param name="service">IPersonService</param>
        public PersonController(IPersonService service)
        {
            Service = service;
        }
        /// <returns>IEnumerable of Person</returns>
        #region Swagger
        [SwaggerOperation("Get All Person")]
        [SwaggerResponse(200,"Return List of Person",typeof(Person))]
        [SwaggerResponse(500,"Server Error")]
        #endregion
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(Service.GetAll().Select(P => P.ToApi()));
        }
        /// <returns>IAction Result</returns>
        #region Swagger
        [SwaggerOperation("Return a Person")]
        [SwaggerResponse(200,"Return one Movie",typeof(Person))]
        [SwaggerResponse(500,"Server Error")]
        #endregion
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute,SwaggerParameter("Id of Person",Required = true)]int id)
        {
            return Ok(Service.Get(id).ToApi());
        }
        #region Swagger
        [SwaggerOperation("Return a list of movie by Person (Producteur or Writer)")]
        [SwaggerResponse(200,"Return list",typeof(PersonMovieListProdWrit))]
        [SwaggerResponse(500,"Server Error")]
        #endregion
        ///<param name="id">int id of person</param>
        ///<returns>IAction Result</returns>
        [HttpGet]
        [Route("MovieByProdWrit/{id}")]
        public IActionResult GetProdWriterMovie([FromRoute,SwaggerParameter("Id of Person",Required = true)]int id)
        {
            PersonMovieListProdWrit personMovieListProdWrit = new PersonMovieListProdWrit();
            personMovieListProdWrit.person = Service.Get(id).ToApi();
            personMovieListProdWrit.personProdWritMovies = Service.GetPersonProdWritMovies(id).Select(PM => PM.ToApi());
            return Ok(personMovieListProdWrit);
        }
        /// <param name="newPerson">NewPersonForm</param>
        /// <returns>IAction Result</returns>
        #region Swagger
        [SwaggerOperation("New Person Form")]
        [SwaggerResponse(200,"Id of Person Created",typeof(int))]
        [SwaggerResponse(400,"Form is Invalid",typeof(ExceptionResponse))]
        [SwaggerResponse(500,"Server Error")]
        #endregion
        [HttpPost]
        public IActionResult Create([FromBody,SwaggerRequestBody("New Person Form",Required = true)]NewPersonForm newPerson)
        {
            try
            {
                int id = Service.Create(newPerson.ToClient());
                return Ok(id);
            }
            catch
            {
                return new BadRequestObjectResult(new ExceptionResponse() { Status = 400,Value = "Form is Invalid" });
            }
        }
        /// <param name="person">Person</param>
        /// <returns>IActionResult</returns>
        #region Swagger
        [SwaggerOperation("Update Person")]
        [SwaggerResponse(200, "Return bool : true if success", typeof(bool))]
        [SwaggerResponse(400, "Form is invalid", typeof(ExceptionResponse))]
        [SwaggerResponse(500, "Server Error")]
        #endregion
        [HttpPut]
        public IActionResult Update([FromBody, SwaggerRequestBody("Update Person Form",Required = true)]Person person)
        {
            try
            {
                return Ok(Service.Update(person.ToClient()));
            }
            catch
            {
                return new BadRequestObjectResult(new ExceptionResponse() { Status = 400, Value = "Form is Invalid" });
            }
        }
        /// <param name="id">int id of Person</param>
        /// <returns>IAction Result</returns>
        #region Swagger
        [SwaggerOperation("Get Person Movie")]
        [SwaggerResponse(200,"Return a Movie by Person",typeof(PersonMovie))]
        [SwaggerResponse(500,"Server Error")]
        #endregion
        [HttpGet]
        [Route("GetPersonMovie/{id}")]
        public IActionResult GetPersonMovie([FromRoute,SwaggerParameter("Id of Person",Required = true)]int id)
        {
            PersonMovie personMovie = new PersonMovie();
            personMovie.Person = Service.Get(id).ToApiShort();
            personMovie.MovieByPerson = Service.GetPersonMovie(id).Select(PM => PM.ToApi()).ToList();
            return Ok(personMovie);
        }
    }
}
