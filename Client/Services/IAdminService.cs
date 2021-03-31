using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Services
{
    public interface IAdminService
    {
        /// <summary>
        /// Function to switch active  an user
        /// </summary>
        /// <param name="id">int id of user</param>
        /// <returns>bool: true if success</returns>
        bool SwitchActiveUser(int id);
        /// <summary>
        /// Function to Switch user in admin or user
        /// </summary>
        /// <param name="id">int id of user</param>
        /// <returns>bool: true if success</returns>
        bool SwitchUser(int id);
    }
}
