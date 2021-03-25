using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Movie.Entities
{
    /// <summary>
    /// Class to describe a Notice related to a movie and user
    /// </summary>
    public class Notice
    {
        public int IdNotice { get; set; }
        public string Content { get; set; }
        public DateTime DateNotice { get; set; }
        public bool IsActive { get; set; }
        public bool IsUsers { get; set; }
    }
}
