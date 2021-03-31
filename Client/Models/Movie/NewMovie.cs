using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models.Movie
{
    /// <summary>
    /// Class to secribe a new movie
    /// </summary>
    public class NewMovie
    {
        public string Title { get; set; }
        public int YearRelease { get; set; }
        public string Synopsis { get; set; }
        public int Director { get; set; }
        public int Writer { get; set; }
    }
}
