using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Notice
{
    /// <summary>
    /// Class to describe a Notice
    /// </summary>
    public class Notice
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime? DateNotice { get; set; }
        public bool IsActive { get; set; }
        public int IdMovie { get; set; }
        public int IdUsers { get; set; }
    }
}
