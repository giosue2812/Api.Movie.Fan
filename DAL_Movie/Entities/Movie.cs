using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Movie.Entities
{
    /// <summary>
    /// Class to describe a movie
    /// </summary>
    public class Movie
    {
        public int IdMovie { get; set; }
        public string Title { get; set; }
        public int YearRelease { get; set; }
        public string Synopsis { get; set; }
        public int Director { get; set; }
        public int Writer { get; set; } 
    }
}
