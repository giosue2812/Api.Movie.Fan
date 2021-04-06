using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Form.Notice
{
    /// <summary>
    /// Class to describe New Notice Form
    /// </summary>
    [SwaggerSchema(Required = new[] {"New Notice Form"})]
    public class NewNoticeForm
    {
        [SwaggerSchema("Content of Notice")]
        [DataType(DataType.MultilineText)]
        [MaxLength(30)]
        public string Content { get; set; }
        [SwaggerSchema("Id of Movie")]
        public int IdMovie { get; set; }
        [SwaggerSchema("Id of User")]
        public int IdUsers { get; set; }
    }
}
