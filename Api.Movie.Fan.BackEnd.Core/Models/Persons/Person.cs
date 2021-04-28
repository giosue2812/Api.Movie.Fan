using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Persons
{
    /// <summary>
    /// Class to describe a Person
    /// </summary>
    [SwaggerSchema(Required = new[] {"Person"})]
    public class Person
    {
        [SwaggerSchema("Id of Person")]
        public int Id { get; set; }
        [SwaggerSchema("First Name of Person")]
        public string FirstName { get; set; }
        [SwaggerSchema("Last Name of Person")]
        public string LastName { get; set; }
        [SwaggerSchema("Concat FirstName and LastName of person")]
        public string CompleteName { get { return FirstName +' '+ LastName; } set { CompleteName = value; } }
    }
}
