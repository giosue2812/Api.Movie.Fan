using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Form.User
{
    /// <summary>
    /// Class to describe a Login Form
    /// </summary>
    [SwaggerSchema(Required = new[] {"Login Form"})]
    public class LoginForm
    {
        [SwaggerSchema("Email of User Form")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [SwaggerSchema("Password of User")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
