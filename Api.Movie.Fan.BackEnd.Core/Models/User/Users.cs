using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.User
{
    public class Users
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Pseudo { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
