using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Movie.Entities
{
    /// <summary>
    /// Class to describe a Person
    /// </summary>
    public class Person
    {
        public int IdPerson { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}
