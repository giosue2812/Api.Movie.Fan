using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Form.Movies
{
    /// <summary>
    /// Class to describe a new Casting
    /// </summary>
    [SwaggerSchema(Required = new[] {"Add Casting"})]
    public class AddCasting
    {
        [SwaggerSchema("Role of actor")]
        [MaxLength(20)]
        public string Role { get; set; }
        [SwaggerSchema("Id of person")]
        public int IdPerson { get; set; }
        [SwaggerSchema("Id of Movie")]
        public int IdMovie { get; set;}
    }
}
