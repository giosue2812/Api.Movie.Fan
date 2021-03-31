using Client.Models.Notice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Services
{
    public interface INoticeService:IService<Notice,int,NewNotice>
    {
        /// <summary>
        /// Function to delete a Notice
        /// </summary>
        /// <param name="id">int id of Notice</param>
        /// <returns>bool:true if sucess</returns>
        bool Delete(int id);
        /// <summary>
        /// Function to get a Notice by movie
        /// </summary>
        /// <param name="id">int id of movie</param>
        /// <returns>NoticeByMovie</returns>
        IEnumerable<NoticeByMovie> GetNoticeByMovie(int id);
        /// <summary>
        /// Function to get a Notice by user
        /// </summary>
        /// <param name="id">int id of user</param>
        /// <returns>NoticeByUser</returns>
        IEnumerable<NoticeByUser> GetNoticeByUsers(int id);
        /// <summary>
        /// Function to update a Notice
        /// </summary>
        /// <param name="movie">Notice</param>
        /// <returns>bool:true if sucess</returns>
        bool Update(Notice entity);
    }
}
