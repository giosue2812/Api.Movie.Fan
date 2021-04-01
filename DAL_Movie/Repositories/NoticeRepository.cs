using DAL_Movie.Entities;
using DAL_Movie.Mappers;
using DAL_Movie.ModelView.Notice;
using DAL_Movie.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool.Connection.DB;

namespace DAL_Movie.Repositories
{
    /// <summary>
    /// Repository for Notice
    /// </summary>
    public class NoticeRepository : RepositoryBase<Notice, int>, INoticeRepository
    {
        /// <summary>
        /// Function to get all notice
        /// </summary>
        /// <returns>IEnumerable Notice</returns>
        public override IEnumerable<Notice> GetAll()
        {
            Command command = new Command("SELECT * FROM V_Notice");
            return Connection.ExecuteReader(command, (N)=>N.ToDal());
        }
        /// <summary>
        /// Function to get one notice
        /// </summary>
        /// <param name="id">int id of notice</param>
        /// <returns></returns>
        public override Notice Get(int id)
        {
            Command command = new Command("SELECT * FROM V_Notice WHERE IdNotice = @IdNotice");
            command.AddParameter("@IdNotice", id);
            return Connection.ExecuteReader(command, (N) => N.ToDal()).SingleOrDefault();
        }
        /// <summary>
        /// Function to insert a new Notice
        /// </summary>
        /// <param name="entity">Notice</param>
        /// <returns>int id of Notice Created</returns>
        public override int Create(Notice entity)
        {
            Command command = new Command("AddNotice", true);
            command.AddParameter("@Content", entity.Content);
            command.AddParameter("@IdMovie", entity.IdMovie);
            command.AddParameter("@IdUsers", entity.IdUsers);
            return (int)Connection.ExecuteScalar(command);
        }
        /// <summary>
        /// Function to update a existing Notice
        /// </summary>
        /// <param name="entity">Notice</param>
        /// <returns>bool: true if sucess</returns>
        public bool Update(Notice entity)
        {
            Command command = new Command("UpdateNotice", true);
            command.AddParameter("@IdNotice", entity.Id);
            command.AddParameter("@Content", entity.Content);
            command.AddParameter("@IdMovie", entity.IdMovie);
            command.AddParameter("@IdUsers", entity.IdUsers);
            return Connection.ExecuteNonQuery(command) == 1;
        }
        /// <summary>
        /// Function to delete a notice
        /// </summary>
        /// <param name="id">int id of notice</param>
        /// <returns>bool: true if sucess</returns>
        public bool Delete(int id)
        {
            Command command = new Command("DeleteNotice", true);
            command.AddParameter("@IdNotice", id);
            bool result = Connection.ExecuteNonQuery(command) == 1;
            if (result) return result;
            else throw new ArgumentException();
        }
        /// <summary>
        /// Function to Get Notice by user
        /// </summary>
        /// <param name="id">int id of user</param>
        /// <returns>NoticeByUser</returns>
        public IEnumerable<NoticeByUser> GetNoticeByUser(int id)
        {
            Command command = new Command("NoticeByUser", true);
            command.AddParameter("@IdUser", id);
            return Connection.ExecuteReader(command, (NU) => NU.ToDalNoticeByUser());
        }
        /// <summary>
        /// Function to Get Notice by movie
        /// </summary>
        /// <param name="id">int id of movie</param>
        /// <returns>NoticeByMovie</returns>
        public IEnumerable<NoticeByMovie> GetNoticeByMovie(int id)
        {
            Command command = new Command("NoticeByMovie", true);
            command.AddParameter("@IdMovie", id);
            return Connection.ExecuteReader(command, (NM) => NM.ToDalNoticeByMovie());
        }
    }
}
