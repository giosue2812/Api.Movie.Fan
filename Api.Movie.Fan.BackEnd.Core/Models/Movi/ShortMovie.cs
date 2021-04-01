using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Movi
{
    /// <summary>
    /// Class to describe a short movie
    /// </summary>
    [SwaggerSchema(Required = new[] {"Short Movie"})]
    public class ShortMovie
    {
        [SwaggerSchema("Id of movie",ReadOnly = true)]
        public int Id { get; set; }
        [SwaggerSchema("Title of movie")]
        public string Title { get; set; }
        [SwaggerSchema("Year release of movie")]
        public int YearRelease { get; set; }
        [SwaggerSchema("Synopsis of movie")]
        public string Synopsis { get; set; }
    }
}
