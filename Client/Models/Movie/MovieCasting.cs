using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models.Movie
{
    /// <summary>
    /// class to describe a Movie with casting
    /// </summary>
    public class MovieCasting
    {
        public string Title { get; set; }
        public string Actor { get; set; }
        public string Role { get; set; }
    }
}
