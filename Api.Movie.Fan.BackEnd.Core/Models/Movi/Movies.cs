using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Movi
{
    /// <summary>
    /// class to describe a Movie
    /// </summary>
    [SwaggerSchema(Required = new[] {"Movie"})]
    public class Movies
    {
        [SwaggerSchema("Id of Movie")]
        public int Id { get; set; }
        [SwaggerSchema("Title of Movie")]
        public string Title { get; set; }
        [SwaggerSchema("Year Release of movie")]
        public int YearRelease { get; set; }
        [SwaggerSchema("Synopsis of Movie")]
        public string Synopsis { get; set; }
        [SwaggerSchema("Id of Director")]
        public int Director { get; set; }
        [SwaggerSchema("Id of Writer")]
        public int Writer { get; set; }
    }
}
