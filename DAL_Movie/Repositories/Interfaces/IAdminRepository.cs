using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Movie.Repositories.Interfaces
{
    public interface IAdminRepository
    {
        /// <summary>
        /// Function to switch active an user
        /// </summary>
        /// <param name="id">int id of user</param>
        /// <returns>bool : true if success</returns>
        bool SwitchActiveUser(int id);
        /// <summary>
        /// Funtion to switch an user in admin or simple user
        /// </summary>
        /// <param name="id">int id of user</param>
        /// <returns>bool : true if success</returns>
        bool SwitchUser(int id);
    }
}
