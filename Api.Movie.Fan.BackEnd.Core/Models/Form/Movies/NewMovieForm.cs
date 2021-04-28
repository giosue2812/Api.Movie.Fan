using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Form.Movies
{
    /// <summary>
    /// Class to describe a New Movie Form
    /// </summary>
    [SwaggerSchema(Required = new[] {"New Movie Form"})]
    public class NewMovieForm
    {

        [SwaggerSchema("Title of new Movie")]
        [MaxLength(50)]
        public string Title { get; set; }
        [SwaggerSchema("Year Release of Movie")]
        public int YearRelease { get; set; }
        [SwaggerSchema("Synopsis of Movie")]
        [DataType(DataType.MultilineText)]
        [MaxLength(1000)]
        public string Synopsis { get; set; }
        [SwaggerSchema("Director")]
        public int Director { get; set; }
        [SwaggerSchema("Writer")]
        public int Writer { get; set; }
    }
}
