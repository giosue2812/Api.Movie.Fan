using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Movi
{
    /// <summary>
    /// class to describe a Movie
    /// </summary>
    public class Movies
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int YearRelease { get; set; }
        public string Synopsis { get; set; }
        public int Director { get; set; }
        public int Writer { get; set; }
    }
}
