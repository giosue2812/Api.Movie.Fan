using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Persons
{
    /// <summary>
    /// Class to describe a list of movie by person
    /// </summary>
    [SwaggerSchema(Required = new[] {"Movie by Producteur or Writer"})]
    public class PersonMovieListProdWrit
    {
        [SwaggerSchema("Person")]
        public Person person { get; set; }
        [SwaggerSchema("List of movie by Producteur or Writer")]
        public IEnumerable<PersonProdWritMovie>? personProdWritMovies { get; set; }
    }
}
