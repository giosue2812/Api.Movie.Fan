using Client.Mappers;
using Client.Models.Users;
using DAL_Movie.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Services
{
    /// <summary>
    /// Service for user
    /// </summary>
    public class UserService : IUserService
    {
        /// <summary>
        /// Private property IUserRepository
        /// </summary>
        private IUserRepository Repository;
        /// <summary>
        /// Constructor UserService
        /// </summary>
        /// <param name="repository">IUserRepository</param>
        public UserService(IUserRepository repository)
        {
            Repository = repository;
        }
        /// <summary>
        /// Funcrtion to get all Users
        /// </summary>
        /// <returns>IEnumerable of Users</returns>
        public IEnumerable<Users> GetAll()
        {
            return Repository.GetAll().Select(U => U.ToClient());
        }
        /// <summary>
        /// Function to get one users
        /// </summary>
        /// <param name="id">inti id of user</param>
        /// <returns>Users</returns>
        public Users Get(int id)
        {
            return Repository.Get(id).ToClient();
        }
        /// <summary>
        /// Funciton to create an users
        /// </summary>
        /// <param name="entity">NewUser</param>
        /// <returns>int id of user created</returns>
        public int Create(NewUser entity)
        {
            return Repository.Create(entity.ToDal());
        }
        /// <summary>
        /// Function to delete an user
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool Delete(int id)
        {
            return Repository.Delete(id);
        }
        /// <summary>
        /// Function to login
        /// </summary>
        /// <param name="users">Users</param>
        /// <returns>Users</returns>
        public Users Login(UserLogin login)
        {
            Users users  = Repository.Login(login.ToDal()).ToClient();
            return users;
        }
        /// <summary>
        /// Function to reset password
        /// </summary>
        /// <param name="userResetPassword">UserResetPassword</param>
        /// <returns>bool:true if success</returns>
        public bool ResetPaswword(UserResetPassword userResetPassword)
        {
            return Repository.ResetPassword(userResetPassword.ToDal());
        }
    }
}
