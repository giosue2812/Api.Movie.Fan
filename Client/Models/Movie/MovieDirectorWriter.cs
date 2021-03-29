using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models.Movie
{
    /// <summary>
    /// class to describe a Movie with Director and Writer
    /// </summary>
    public class MovieDirectorWriter
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public int YearRelease { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
    }
}
