using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models.Notice
{
    public class NoticeByMovie
    {
        public string Email { get; set; }
        public string Content { get; set; }
        public DateTime DateNotice { get; set; }
    }
}
