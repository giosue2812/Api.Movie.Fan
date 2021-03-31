using Api.Movie.Fan.BackEnd.Core.Models.Movi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Persons
{
    /// <summary>
    /// Class To describe a Person with movie
    /// </summary>
    public class PersonMovie
    {
        public Person Person { get; set; }
        public IEnumerable<MovieByPerson>? MovieByPerson { get; set; }
    }
}
