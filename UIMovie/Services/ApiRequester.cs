using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using UIMovie.Model;

namespace UIMovie.Services
{
    public class ApiRequester:IApiRequester
    {
        private HttpClient Client;
        public ApiRequester(string BaseAdress)
        {
            this.Client = new HttpClient();
            this.Client.BaseAddress = new Uri("http://localhost:60000/api/");
        }

        public IEnumerable<Movie> getMovies()
        {
            using(HttpResponseMessage message = Client.GetAsync("movie").Result)
            {
                message.EnsureSuccessStatusCode();
                string json = message.Content.ReadAsStringAsync().Result;
                return JsonSerializer.Deserialize<IEnumerable<Movie>>(json);
            }
        }
    }
}
