using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Movi
{
    /// <summary>
    /// class to describe a Movie Director Writer
    /// </summary>
    [SwaggerSchema(Required = new[] {"Movie with Director"})]
    public class MovieDirectorWriter
    {
        [SwaggerSchema("Id of movie",ReadOnly =true)]
        public int Id { get; set; }
        [SwaggerSchema("Title of movie")]
        public string Title { get; set; }
        [SwaggerSchema("Synopsis of movie")]
        public string Synopsis { get; set; }
        [SwaggerSchema("Year release of movie")]
        public int YearRelease { get; set; }
        [SwaggerSchema("Director of movie")]
        public string Director { get; set; }
        [SwaggerSchema("Writer of movie")]
        public string Writer { get; set; }
    }
}
