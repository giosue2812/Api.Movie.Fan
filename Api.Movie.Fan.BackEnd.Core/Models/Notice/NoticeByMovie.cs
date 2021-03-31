using Api.Movie.Fan.BackEnd.Core.Models.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Notice
{
    /// <summary>
    /// Class to describe a notice by movie
    /// </summary>
    public class NoticeByMovie
    {
        public string Email { get; set; }
        public string Content { get; set; }
        public DateTime DateNotice { get; set; }
    }
}
