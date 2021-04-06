using Api.Movie.Fan.BackEnd.Core.Models.Movi;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Persons
{
    /// <summary>
    /// Class To describe a Person with movie
    /// </summary>
    [SwaggerSchema(Required = new[] {"Person Movie"})]
    public class PersonMovie
    {
        [SwaggerSchema("Person")]
        public Person Person { get; set; }
        [SwaggerSchema("List of Movie By Person")]
        public IEnumerable<MovieByPerson>? MovieByPerson { get; set; }
    }
}
