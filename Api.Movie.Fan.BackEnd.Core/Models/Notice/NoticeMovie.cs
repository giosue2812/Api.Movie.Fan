using Api.Movie.Fan.BackEnd.Core.Models.Movi;
using Api.Movie.Fan.BackEnd.Core.Models.Persons;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;


namespace Api.Movie.Fan.BackEnd.Core.Models.Notice
{
    /// <summary>
    /// Class to describe a movie with list of notice
    /// </summary>
    [SwaggerSchema(Required = new[] {"Notice Movie"})]
    public class NoticeMovie
    {
        [SwaggerSchema("Short Movie")]
        public ShortMovie Movie { get; set; }
        [SwaggerSchema("List of Notice By Movie")]
        public IEnumerable<NoticeByMovie> NoticeByMovie { get; set; }
    }
}
