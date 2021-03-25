using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Movie.Entities
{
    /// <summary>
    /// Class to describe a Casting related to a movie and person wich role played.
    /// </summary>
    public class Casting
    {
        public int IdCasting { get; set; }
        public string Role { get; set; }
        public int IdPerson { get; set; }
        public int IdMovie { get; set; }

    }
}
