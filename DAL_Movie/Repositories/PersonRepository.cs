using DAL_Movie.Entities;
using DAL_Movie.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Movie.Repositories
{
    public class PersonRepository : IRepository<Person, int>
    {
        public int Create(Person entity)
        {
            throw new NotImplementedException();
        }

        public Person Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Person> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}
