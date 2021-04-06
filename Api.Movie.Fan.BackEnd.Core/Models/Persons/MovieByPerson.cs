using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Persons
{
    /// <summary>
    /// Class to describe a Movie by person
    /// </summary>
    [SwaggerSchema(Required = new[] {"Notice By Person"})]
    public class MovieByPerson
    {
        [SwaggerSchema("Title of Movie")]
        public string Title { get; set; }
        [SwaggerSchema("Synopsis of Movie")]
        public string Synopsis { get; set; }
    }
}
