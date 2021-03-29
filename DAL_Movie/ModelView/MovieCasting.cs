using DAL_Movie.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Movie.ModelView
{
    /// <summary>
    /// class to describe a MovieCasting
    /// </summary>
    public class MovieCasting
    {
        public string Title { get; set; }
        public string Actor { get;set; }
        public string Role { get; set; }
    }
}
