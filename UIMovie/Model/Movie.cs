using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UIMovie.Model
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int YearRelease { get; set; }
        public string Synopsis { get; set; }
    }
}
