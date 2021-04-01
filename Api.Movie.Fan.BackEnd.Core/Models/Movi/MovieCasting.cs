using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;


namespace Api.Movie.Fan.BackEnd.Core.Models.Movi
{
    [SwaggerSchema(Required = new[] {"Moivie with casting"})]
    public class MovieCasting
    {
        [SwaggerSchema("Short Movie")]
        public ShortMovie Movies { get; set; }
        [SwaggerSchema("List of casting")]
        public IEnumerable<Casting>? Castings { get; set; }
    }
}
