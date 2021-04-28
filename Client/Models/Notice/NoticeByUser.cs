using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models.Notice
{
    public class NoticeByUser
    {
        public bool IsActive { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime DateNotice { get; set; }
    }
}
