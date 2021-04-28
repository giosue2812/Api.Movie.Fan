using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Models.Users
{
    public class Users
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Pseudo { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
    }
}
