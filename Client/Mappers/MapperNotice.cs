using Client.Models.Notice;
using DAL = DAL_Movie;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Mappers
{
    /// <summary>
    /// Mapper for Notice
    /// </summary>
    public static class MapperNotice
    {
        /// <summary>
        /// Funtion to convert a DAL Notice to Client Notice
        /// </summary>
        /// <param name="entity">DAL Notice</param>
        /// <returns>Client Notice</returns>
        public static Notice ToClient(this DAL.Entities.Notice entity)
        {
            if (entity == null) return null;
            return new Notice
            {
                Id = entity.Id,
                Content = entity.Content,
                DateNotice = entity.DateNotice,
                IdMovie = entity.IdMovie,
                IdUsers = entity.IdUsers,
                IsActive = entity.IsActive
            };
        }
        /// <summary>
        /// Function to convert a Client NewNotice to DAL Notice
        /// </summary>
        /// <param name="newNotice">Client NewNotice</param>
        /// <returns>DAL Notice</returns>
        public static DAL.Entities.Notice ToDal(this NewNotice newNotice)
        {
            if (newNotice == null) return null;
            return new DAL.Entities.Notice
            {
                Content = newNotice.Content,
                IdMovie = newNotice.IdMovie,
                IdUsers = newNotice.IdUsers,
            };
        }
        /// <summary>
        /// Function to convert a Client Notice to DAL Notice
        /// </summary>
        /// <param name="notice">Client Notice</param>
        /// <returns>DAL Notice</returns>
        public static DAL.Entities.Notice ToDal(this Notice notice)
        {
            if (notice == null) return null;
            return new DAL.Entities.Notice
            {
                Id = notice.Id,
                Content = notice.Content,
                IdMovie = notice.IdMovie,
                IdUsers = notice.IdUsers,
                IsActive = true
            };
        }
        /// <summary>
        /// Function to convert DAL NoticeByUser to Client NoticeByUser
        /// </summary>
        /// <param name="entity">DAL NoticeByUser</param>
        /// <returns>Client NoticeByUser</returns>
        public static NoticeByUser ToClient(this DAL.ModelView.Notice.NoticeByUser entity)
        {
            if (entity == null) return null;
            return new NoticeByUser
            {
                Content = entity.Content,
                DateNotice = entity.DateNotice,
                Title = entity.Title
            };
        }
        /// <summary>
        /// Function to convert DAL NoticeByMovie to Client NoticeByMovie
        /// </summary>
        /// <param name="entity">DAL NoticeByMovie</param>
        /// <returns>Client NoticeByMovie</returns>
        public static NoticeByMovie ToClient(this DAL.ModelView.Notice.NoticeByMovie entity)
        {
            if (entity == null) return null;
            return new NoticeByMovie
            {
                Content = entity.Content,
                DateNotice = entity.DateNotice,
                Email = entity.Email
            };
        }
    }
}
