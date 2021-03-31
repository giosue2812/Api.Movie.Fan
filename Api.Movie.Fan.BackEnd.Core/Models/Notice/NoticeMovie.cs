using Api.Movie.Fan.BackEnd.Core.Models.Movi;
using Api.Movie.Fan.BackEnd.Core.Models.Persons;
using System.Collections.Generic;


namespace Api.Movie.Fan.BackEnd.Core.Models.Notice
{
    /// <summary>
    /// Class to describe a movie with list of notice
    /// </summary>
    public class NoticeMovie
    {
        public ShortMovie Movie { get; set; }
        public IEnumerable<NoticeByMovie> NoticeByMovie { get; set; }
    }
}
