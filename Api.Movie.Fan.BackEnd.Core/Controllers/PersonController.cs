using Client.Services;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Api.Movie.Fan.BackEnd.Core.Mappers;
using Api.Movie.Fan.BackEnd.Core.Models.Form.Persons;
using Api.Movie.Fan.BackEnd.Core.Models.Persons;
using Api.Movie.Fan.BackEnd.Core.Models.Movi;

namespace Api.Movie.Fan.BackEnd.Core.Controllers
{
    /// <summary>
    /// Controller Person
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        /// <summary>
        /// Private of type IPersonService
        /// </summary>
        private IPersonService Service;
        /// <summary>
        /// Constructor of Controller wich implement a IPersonService
        /// </summary>
        /// <param name="service">IPersonService</param>
        public PersonController(IPersonService service)
        {
            Service = service;
        }
        /// <summary>
        /// Function to GetAll Person
        /// </summary>
        /// <returns>IEnumerable of Person</returns>
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(Service.GetAll().Select(P => P.ToApi()));
        }
        /// <summary>
        /// Function to Get one Person
        /// </summary>
        /// <returns>IAction Result</returns>
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(Service.Get(id).ToApi());
        }
        /// <summary>
        /// Function to create a new Person
        /// </summary>
        /// <param name="newPerson">NewPersonForm</param>
        /// <returns>IAction Result</returns>
        [HttpPost]
        public IActionResult Create(NewPersonForm newPerson)
        {
            try
            {
                int id = Service.Create(newPerson.ToClient());
                return Ok(id);
            }
            catch
            {
                return new BadRequestObjectResult(new { error="Form is invalid" });
            }
        }
        /// <summary>
        /// Function to update a Person
        /// </summary>
        /// <param name="person">Person</param>
        /// <returns>IActionResult</returns>
        [HttpPut]
        public IActionResult Update(Person person)
        {
            try
            {
                return Ok(Service.Update(person.ToClient()));
            }
            catch
            {
                return new BadRequestObjectResult(new { error = "Form is invalid" });
            }
        }
        /// <summary>
        /// Function to Get a Person with list of movie
        /// </summary>
        /// <param name="id">int id of Person</param>
        /// <returns>IAction Result</returns>
        [HttpGet]
        [Route("GetPersonMovie/{id}")]
        public IActionResult GetPersonMovie(int id)
        {
            PersonMovie personMovie = new PersonMovie();
            personMovie.Person = Service.Get(id).ToApiShort();
            personMovie.MovieByPerson = Service.GetPersonMovie(id).Select(PM => PM.ToApi()).ToList();
            return Ok(personMovie);
        }
    }
}
