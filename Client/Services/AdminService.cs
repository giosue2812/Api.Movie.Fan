using DAL_Movie.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Services
{
    /// <summary>
    /// Service Admin
    /// </summary>
    public class AdminService:IAdminService
    {
        /// <summary>
        /// Private property IAdminService
        /// </summary>
        private IAdminRepository Repository;
        /// <summary>
        /// Constructor of service admin
        /// </summary>
        /// <param name="repository">IAdminRepository</param>
        public AdminService(IAdminRepository repository)
        {
            Repository = repository;
        }
        /// <summary>
        /// Function to switch active an user
        /// </summary>
        /// <param name="id">int id of user</param>
        /// <returns>bool: true if success</returns>
        public bool SwitchActiveUser(int id)
        {
            return Repository.SwitchActiveUser(id) ;
        }
        /// <summary>
        /// Function to Switch user in admin or user
        /// </summary>
        /// <param name="id">int id of user</param>
        /// <returns>bool: true if success</returns>
        public bool SwitchUser(int id)
        {
            return Repository.SwitchUser(id);
        }
    }
}
