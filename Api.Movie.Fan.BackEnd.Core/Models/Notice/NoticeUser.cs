using Api.Movie.Fan.BackEnd.Core.Models.User;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Notice
{
    /// <summary>
    /// Class to describe a Notice User
    /// </summary>
    [SwaggerSchema(Required = new[] {"Notice User"})]
    public class NoticeUser
    {
        [SwaggerSchema("User Short")]
        public UserShort User { get; set; }
        [SwaggerSchema("List of Notice By User")]
        public IEnumerable<NoticeByUser> NoticeByUsers { get; set; }
    }
}
