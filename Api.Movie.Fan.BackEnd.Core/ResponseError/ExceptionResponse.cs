using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.ResponseError
{
    /// <summary>
    /// Class to describe an Exception Response
    /// </summary>
    [SwaggerSchema(Required = new[] {"Exception Response"})]
    public class ExceptionResponse
    {
        [SwaggerSchema("Status of Exception")]
        public int Status { get; set; }
        [SwaggerSchema("Value of Exception")]
        public string Value { get; set; }
    }
}
