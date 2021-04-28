using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.User
{
    /// <summary>
    /// Class to describe an Short User
    /// </summary>
    [SwaggerSchema(Required = new[] {"User Short"})]
    public class UserShort
    {
        [SwaggerSchema("id of user")]
        public int Id { get; set; }
        [SwaggerSchema("Email of User")]
        public string Email { get; set; }
        [SwaggerSchema("Pseudo of User")]
        public string Pseudo { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
    }
}
