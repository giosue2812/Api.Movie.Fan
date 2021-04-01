using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Notice
{
    /// <summary>
    /// Class to describe a Notice
    /// </summary>
    [SwaggerSchema(Required = new[] {"Notice"})]
    public class Notice
    {
        [SwaggerSchema("Id of Notice")]
        public int Id { get; set; }
        [SwaggerSchema("Content of Notice")]
        public string Content { get; set; }
        [SwaggerSchema("Date of the notice")]
        public DateTime? DateNotice { get; set; }
        [SwaggerSchema("bool Content active or not")]
        public bool IsActive { get; set; }
        [SwaggerSchema("Id of Movie")]
        public int IdMovie { get; set; }
        [SwaggerSchema("Id of User")]
        public int IdUsers { get; set; }
    }
}
