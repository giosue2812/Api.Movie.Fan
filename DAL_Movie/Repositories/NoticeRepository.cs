using DAL_Movie.Entities;
using DAL_Movie.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Movie.Repositories
{
    public class NoticeRepository : IRepository<Notice, int>
    {
        public int Create(Notice entity)
        {
            throw new NotImplementedException();
        }

        public Notice Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Notice> GetAll()
        {
            throw new NotImplementedException();
        }

        public bool Update(Notice entity)
        {
            throw new NotImplementedException();
        }
    }
}
