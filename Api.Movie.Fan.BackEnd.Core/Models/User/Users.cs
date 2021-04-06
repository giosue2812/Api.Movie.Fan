using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.User
{
    /// <summary>
    /// Class to describe an Users
    /// </summary>
    [SwaggerSchema(Required = new[] {"Users"})]
    public class Users
    {
        [SwaggerSchema("Id of User")]
        public int Id { get; set; }
        [SwaggerSchema("Email of User")]
        public string Email { get; set; }
        [SwaggerSchema("Pseudo of User")]
        public string Pseudo { get; set; }
        [SwaggerSchema("Birth Date of User")]
        public DateTime BirthDate { get; set; }
    }
}
