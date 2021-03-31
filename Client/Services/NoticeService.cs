using Client.Mappers;
using Client.Models.Notice;
using DAL_Movie.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Services
{
    /// <summary>
    /// Service for notice
    /// </summary>
    public class NoticeService : INoticeService
    {
        /// <summary>
        /// Private property of type INoticeRepository
        /// </summary>
        private INoticeRepository Repository;
        /// <summary>
        /// Constructor of Notice Service
        /// </summary>
        /// <param name="repository">INoticeRepository</param>
        public NoticeService(INoticeRepository repository)
        {
            Repository = repository;
        }
        /// <summary>
        /// Function to get all Notice
        /// </summary>
        /// <returns>Notice</returns>
        public IEnumerable<Notice> GetAll()
        {
            return Repository.GetAll().Select(N => N.ToClient());
        }
        /// <summary>
        /// Function to get one Notice
        /// </summary>
        /// <param name="id">int id of Notice</param>
        /// <returns>Notice</returns>
        public Notice Get(int id)
        {
            return Repository.Get(id).ToClient();
        }
        /// <summary>
        /// Function to create a new Notice
        /// </summary>
        /// <param name="entity">NewNotice</param>
        /// <returns>int id of notice created</returns>
        public int Create(NewNotice entity)
        {
            return Repository.Create(entity.ToDal());
        }
        /// <summary>
        /// Function to Update a Existing Notice
        /// </summary>
        /// <param name="entity">Notice</param>
        /// <returns>bool:true if success</returns>
        public bool Update(Notice entity)
        {
            return Repository.Update(entity.ToDal());
        }
        /// <summary>
        /// Function to get Notice by Movie
        /// </summary>
        /// <param name="id">int id of Movie</param>
        /// <returns>NoticeByMovie</returns>
        public IEnumerable<NoticeByMovie> GetNoticeByMovie(int id)
        {
            return Repository.GetNoticeByMovie(id).Select(NM =>NM.ToClient());
        }
        /// <summary>
        /// Function to get Notice by User
        /// </summary>
        /// <param name="id">int id of User</param>
        /// <returns>NoticeByUser</returns>
        public IEnumerable<NoticeByUser> GetNoticeByUsers(int id)
        {
            return Repository.GetNoticeByUser(id).Select(NU => NU.ToClient());
        }
        /// <summary>
        /// Function to delete a Notice
        /// </summary>
        /// <param name="id">int id of Notice</param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            return Repository.Delete(id);
        }
    }
}
