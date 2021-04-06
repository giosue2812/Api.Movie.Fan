using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Notice
{
    /// <summary>
    /// Class to describe a notice by user
    /// </summary>
    [SwaggerSchema(Required = new[] {"Notice By User"})]
    public class NoticeByUser
    {
        [SwaggerSchema("Title of Movie")]
        public string Title { get; set; }
        [SwaggerSchema("Content of Notice")]
        public string Content { get; set; }
        [SwaggerSchema("Notice Date")]
        public DateTime DateNotice { get; set; }
    }
}
