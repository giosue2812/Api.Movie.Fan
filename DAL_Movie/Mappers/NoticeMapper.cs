using DAL_Movie.Entities;
using DAL_Movie.ModelView.Notice;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Movie.Mappers
{
    /// <summary>
    /// Mapper to Convert Notice object
    /// </summary>
    public static class NoticeMapper
    {
        /// <summary>
        /// Function to convert Notice from database to DAL Notice
        /// </summary>
        /// <param name="record">IDataRecord</param>
        /// <returns>DAL Notice</returns>
        public static Notice ToDal(this IDataRecord record)
        {
            if (record == null) return null;
            return new Notice
            {
                Id = (int)record["IdNotice"],
                Content = (string)record["Content"],
                DateNotice = (DateTime)record["DateNotice"],
                IsActive = (bool)record["IsActive"],
                IdMovie = (int)record["IdMovie"],
                IdUsers = (int)record["IdUsers"]
            };
        }
        /// <summary>
        /// Function to convert NoticeByUser from database to DAL NoticeByUser
        /// </summary>
        /// <param name="record">IDataRecord</param>
        /// <returns>DAL NoticeByUser</returns>
        public static NoticeByUser ToDalNoticeByUser(this IDataRecord record)
        {
            if (record == null) return null;
            return new NoticeByUser
            {
                Title = (string)record["Title"],
                Content = (string)record["Content"],
                DateNotice = (DateTime)record["DateNotice"]
            };
        }
        /// <summary>
        /// Function to convert NoticeByMovie from database to DAL NoticeByMovie
        /// </summary>
        /// <param name="record">IDataRecord</param>
        /// <returns>DAL NoticeByMovie</returns>
        public static NoticeByMovie ToDalNoticeByMovie(this IDataRecord record)
        {
            if (record == null) return null;
            return new NoticeByMovie
            {
                Email = (string)record["Email"],
                Content = (string)record["Content"],
                DateNotice = (DateTime)record["DateNotice"]
            };
        }
    }
}
