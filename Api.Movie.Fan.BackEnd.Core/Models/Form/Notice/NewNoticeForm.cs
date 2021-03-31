using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Form.Notice
{
    public class NewNoticeForm
    {
        public string Content { get; set; }
        public int IdMovie { get; set; }
        public int IdUsers { get; set; }
    }
}
