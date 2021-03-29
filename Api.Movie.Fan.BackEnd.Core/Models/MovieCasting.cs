using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models
{
    /// <summary>
    /// class to describe a movie casting
    /// </summary>
    public class MovieCasting
    {
        public string Title { get; set; }
        public string Actor { get; set; }
        public string Role { get; set; }
    }
}
