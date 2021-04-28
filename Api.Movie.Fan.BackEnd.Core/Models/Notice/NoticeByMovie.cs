using Api.Movie.Fan.BackEnd.Core.Models.Persons;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Notice
{
    /// <summary>
    /// Class to describe a notice by movie
    /// </summary>
    [SwaggerSchema(Required = new[] {"Notice By movie"})]
    public class NoticeByMovie
    {
        [SwaggerSchema("Active Comment")]
        public bool IsActive { get; set; }
        [SwaggerSchema("Email of User")]
        public string Email { get; set; }
        [SwaggerSchema("Notice Content")]
        public string Content { get; set; }
        [SwaggerSchema("Notice Date")]
        public DateTime DateNotice { get; set; }
    }
}
