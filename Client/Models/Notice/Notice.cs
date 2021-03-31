using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models.Notice
{
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
