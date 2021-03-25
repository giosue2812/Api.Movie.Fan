using DAL_Movie.Entities;
using DAL_Movie.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Movie.Repositories
{
    public class MovieRepositry : IRepositoryBase<Movie, int>
    {
        public TResult Create<TResult, TBody>(TBody entity)
        {
            throw new NotImplementedException();
        }

        public TResult Delete<TResult>(int id)
        {
            throw new NotImplementedException();
        }

        public Movie Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Movie> GetAll()
        {
            throw new NotImplementedException();
        }

        public TResult Update<TResult, TBody>(TBody entity)
        {
            throw new NotImplementedException();
        }
    }
}
