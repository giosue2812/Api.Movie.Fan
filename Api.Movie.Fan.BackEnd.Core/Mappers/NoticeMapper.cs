using Api.Movie.Fan.BackEnd.Core.Models.Notice;
using CL = Client.Models.Notice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Movie.Fan.BackEnd.Core.Models.Form.Notice;
using Api.Movie.Fan.BackEnd.Core.Models.Movi;

namespace Api.Movie.Fan.BackEnd.Core.Mappers
{
    /// <summary>
    /// Mapper for Notice
    /// </summary>
    public static class NoticeMapper
    {
        /// <summary>
        /// Function to convert a Client Notice to API Notice
        /// </summary>
        /// <param name="notice">Client Notice</param>
        /// <returns>API Notice</returns>
        public static Notice ToApi(this CL.Notice entity)
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
        /// Function to convert API Notice to Client Notice
        /// </summary>
        /// <param name="notice">API Notice</param>
        /// <returns>Client Notice</returns>
        public static CL.Notice ToClient(this Notice notice)
        {
            if (notice == null) return null;
            return new CL.Notice
            {
                Id = notice.Id,
                Content = notice.Content,
                IdMovie = notice.IdMovie,
                IdUsers = notice.IdUsers,
                IsActive = true
            };
        }
        /// <summary>
        /// Function to convert a API NewFormNotice to Client NewNotice
        /// </summary>
        /// <param name="newNotice">API NewNoticeForm</param>
        /// <returns>Client NewNotice</returns>
        public static CL.NewNotice ToClient(this NewNoticeForm newNotice)
        {
            if (newNotice == null) return null;
            return new CL.NewNotice
            {
                Content = newNotice.Content,
                IdMovie = newNotice.IdMovie,
                IdUsers = newNotice.IdUsers
            };
        }
        /// <summary>
        /// Function to convert Client NoticeByMovie to API NoticeByMovie
        /// </summary>
        /// <param name="entity">Client NoticeByMovie</param>
        /// <returns>API NoticeByMovie</returns>
        public static NoticeByMovie ToApi(this CL.NoticeByMovie entity)
        {
            if (entity == null) return null;
            return new NoticeByMovie
            {
                IsActive = entity.IsActive,
                Content = entity.Content,
                DateNotice = entity.DateNotice,
                Email = entity.Email
            };
        }
        /// <summary>
        /// Function to convert Client NoticeByUser to API NoticeByUser
        /// </summary>
        /// <param name="entity">Client NoticeByUser</param>
        /// <returns>API NoticeByUser</returns>
        public static NoticeByUser ToApi(this CL.NoticeByUser entity)
        {
            if (entity == null) return null;
            return new NoticeByUser
            {
                IsActive = entity.IsActive,
                Content = entity.Content,
                DateNotice = entity.DateNotice,
                Title = entity.Title
            };
        }
    }
}
