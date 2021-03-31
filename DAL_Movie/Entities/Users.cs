using DAL_Movie.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Movie.Entities
{
    /// <summary>
    /// User class to describe an User
    /// </summary>
    public class Users:IEntity<int>
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Pseudo { get; set; }
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }
    }
}
