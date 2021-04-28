using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UIMovie.Model;

namespace UIMovie.Services
{
    public interface IApiRequester
    {
        IEnumerable<Movie> getMovies();
    }
}
