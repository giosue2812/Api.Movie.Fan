using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Form.Movies
{
    public class NewMovieForm
    {
        public string Title { get; set; }
        public int YearRelease { get; set; }
        public string Synopsis { get; set; }
        public int Director { get; set; }
        public int Writer { get; set; }
    }
}
