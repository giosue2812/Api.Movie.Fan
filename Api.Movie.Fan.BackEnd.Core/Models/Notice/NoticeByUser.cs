using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Notice
{
    public class NoticeByUser
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateNotice { get; set; }
    }
}
