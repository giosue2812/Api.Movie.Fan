using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Movi
{
    /// <summary>
    /// Class to describe a casting
    /// </summary>
    [SwaggerSchema(Required = new[] {"Casting"})]
    public class Casting
    {
        [SwaggerSchema("Actor")]
        public string Actor { get; set; }
        [SwaggerSchema("Role played by Actor")]
        public string Role { get; set; }
    }
}
