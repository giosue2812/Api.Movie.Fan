using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Movi
{
    /// <summary>
    /// Class to describe a short movie
    /// </summary>
    public class ShortMovie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int YearRelease { get; set; }
        public string Synopsis { get; set; }
    }
}
