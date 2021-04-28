using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Movie.ModelView.Movie
{
    public class AddCasting
    {
        public string Role { get; set; }
        public int IdPerson { get; set; }
        public int IdMovie { get; set; }
    }
}
