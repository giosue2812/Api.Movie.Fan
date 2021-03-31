using Api.Movie.Fan.BackEnd.Core.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Notice
{
    public class NoticeUser
    {
        public UserShort User { get; set; }
        public IEnumerable<NoticeByUser> NoticeByUsers { get; set; }
    }
}
