using DAL_Movie.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Movie.Repositories.Interfaces
{
    /// <summary>
    /// Interface for user repository
    /// </summary>
    public interface IUserRepository:IRepository<Users,int>
    {
        /// <summary>
        /// Function to delete an User
        /// </summary>
        /// <param name="id">int id of user</param>
        /// <returns>bool:true if success</returns>
        bool Delete(int id);
        /// <summary>
        /// Funciton to login
        /// </summary>
        /// <param name="users">Users</param>
        /// <returns>Users</returns>
        Users Login(Users users);
        /// <summary>
        /// Function to reset password
        /// </summary>
        /// <param name="users">Users</param>
        /// <returns>bool: true if success</returns>
        bool ResetPassword(Users users);
    }
}
