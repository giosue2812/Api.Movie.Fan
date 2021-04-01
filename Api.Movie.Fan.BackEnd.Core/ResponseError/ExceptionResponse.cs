using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.ResponseError
{
    public class ExceptionResponse
    {
        public int Status { get; set; } = 500;
        public string Value { get; set; } = "Server Error";
    }
}
