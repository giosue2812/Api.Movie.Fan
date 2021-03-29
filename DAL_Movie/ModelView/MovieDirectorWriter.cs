using DAL_Movie.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Movie.ModelView
{
    /// <summary>
    /// Class to describe a MovieDirectorWriter
    /// </summary>
    public class MovieDirectorWriter : IEntity<int>
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public int YearRelease { get; set; }
        public string Director { get; set; }
        public string Writer { get; set; }
    }
}
