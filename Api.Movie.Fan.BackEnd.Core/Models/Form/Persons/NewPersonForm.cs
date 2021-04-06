using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Form.Persons
{
    /// <summary>
    /// Class to describe a New Person Form
    /// </summary>
    [SwaggerSchema(Required = new[] {"New Person Form"})]
    public class NewPersonForm
    {
        [SwaggerSchema("First Name of Person")]
        [MaxLength(20)]
        [MinLength(5)]
        public string FirstName { get; set; }
        [SwaggerSchema("Last Name of Person")]
        [MaxLength(20)]
        [MinLength(5)]
        public string LastName { get; set; }
    }
}
