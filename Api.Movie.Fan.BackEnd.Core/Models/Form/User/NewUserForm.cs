using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Form.User
{
    /// <summary>
    /// Class to describe a New User Form
    /// </summary>
    [SwaggerSchema(Required = new[] {"New User Form"})]
    public class NewUserForm
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [SwaggerSchema("Email of New User")]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [MaxLength(20)]
        [MinLength(6)]
        [SwaggerSchema("Password pf New User")]
        public string Password { get; set; }
        [Required]
        [DataType("current_date")]
        [SwaggerSchema("Birth Date of new User")]
        public DateTime BirthDate { get; set; }
    }
}
