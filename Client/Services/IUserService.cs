using Client.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Services
{
    public interface IUserService:IService<Users,int,NewUser>
    {
        /// <summary>
        /// Function to delete an User
        /// </summary>
        /// <param name="id">int id of user</param>
        /// <returns>bool : true if success</returns>
        bool Delete(int id);
        /// <summary>
        /// Function to login
        /// </summary>
        /// <param name="users">Users</param>
        /// <returns>Users</returns>
        Users Login(UserLogin login);
        /// <summary>
        /// Function to reset password
        /// </summary>
        /// <param name="userResetPassword">UserResetPassword</param>
        /// <returns>bool:true if success</returns>
        bool ResetPaswword(UserResetPassword userResetPassword);
    }
}
