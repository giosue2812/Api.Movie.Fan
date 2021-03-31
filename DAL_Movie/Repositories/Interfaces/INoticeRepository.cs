using DAL_Movie.Entities;
using DAL_Movie.ModelView.Notice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Movie.Repositories.Interfaces
{
    /// <summary>
    /// INoticeRepository for Notice repository only
    /// </summary>
    public interface INoticeRepository : IRepository<Notice, int>
    {
        /// <summary>
        /// Function to delete a notice
        /// </summary>
        /// <param name="id">int id of notice</param>
        /// <returns>bool: true if sucess</returns>
        bool Delete(int id);
        /// <summary>
        /// Function to Get Notice By Movie
        /// </summary>
        /// <param name="id">int id of movie</param>
        /// <returns>NoticeByMovie</returns>
        IEnumerable<NoticeByMovie> GetNoticeByMovie(int id);
        /// <summary>
        /// Function to get Notice by User
        /// </summary>
        /// <param name="id">int id of user</param>
        /// <returns>NoticeByUser</returns>
        IEnumerable<NoticeByUser> GetNoticeByUser(int id);
        /// <summary>
        /// Function to update a Notice
        /// </summary>
        /// <param name="entity">Notice</param>
        /// <returns>bool: true if success</returns>
        bool Update(Notice entity);
    }
}
