using System.Collections.Generic;


namespace Api.Movie.Fan.BackEnd.Core.Models.Movi
{
    /// <summary>
    /// class to describe a movie casting
    /// </summary>
    public class MovieCasting
    {
        public ShortMovie Movies { get; set; }
        public IEnumerable<Casting>? Castings { get; set; }
    }
}
