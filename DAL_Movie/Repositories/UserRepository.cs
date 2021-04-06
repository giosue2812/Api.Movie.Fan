using DAL_Movie.Entities;
using DAL_Movie.Mappers;
using DAL_Movie.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using Tool.Connection.DB;

namespace DAL_Movie.Repositories
{
    /// <summary>
    /// Repository for user
    /// </summary>
    public class UserRepository : RepositoryBase<Users, int>, IUserRepository,IAdminRepository
    {
        /// <summary>
        /// Function to get all User
        /// </summary>
        /// <returns>Users</returns>
        public override IEnumerable<Users> GetAll()
        {
            Command command = new Command("SELECT * FROM V_User_List");
            return Connection.ExecuteReader(command,(u) => u.ToDalUser());
        }
        /// <summary>
        /// Function to get one User
        /// </summary>
        /// <param name="id">int id of User</param>
        /// <returns>Users</returns>
        public override Users Get(int id)
        {
            Command command = new Command("SELECT * FROM V_User_List WHERE Id = @Id");
            command.AddParameter("@Id", id);
            return Connection.ExecuteReader(command, (u) => u.ToDalUser()).SingleOrDefault();
        }
        /// <summary>
        /// Function to create a new User
        /// </summary>
        /// <param name="entity">Users</param>
        /// <returns>int id of User created</returns>
        public override int Create(Users entity)
        {
            Command command = new Command("AddUser",true);
            command.AddParameter("@Email", entity.Email);
            command.AddParameter("@Password", entity.Password);
            command.AddParameter("@BirthDate", entity.BirthDate);
            return (int)Connection.ExecuteScalar(command);
        }
        /// <summary>
        /// Function to Login user
        /// </summary>
        /// <param name="users">Users</param>
        /// <returns>Users</returns>
        public Users Login(Users users)
        {
            Command command = new Command("LoginUser",true);
            command.AddParameter("@Email", users.Email);
            command.AddParameter("@Password", users.Password);
            Users user = Connection.ExecuteReader(command,(m) => m.ToDalUser()).SingleOrDefault();
            if (user != null) return user;
            else throw new Exception();
        }
        /// <summary>
        /// Function to delete an User
        /// </summary>
        /// <param name="id">int id of user</param>
        /// <returns>boll: true if success</returns>
        public bool Delete(int id)
        {
            Command command = new Command("DeleteUser",true);
            command.AddParameter("@IdUser", id);
            return Connection.ExecuteNonQuery(command) == 1;
        }
        /// <summary>
        /// Function to reset password
        /// </summary>
        /// <param name="users">Users</param>
        /// <returns>bool: true if success</returns>
        public bool ResetPassword(Users users)
        {
            Command command = new Command("ResetPassword", true);
            command.AddParameter("@IdUser", users.Id);
            command.AddParameter("@Email", users.Email);
            command.AddParameter("@Password", users.Password);
            bool result = Connection.ExecuteNonQuery(command) == 1;
            if (result) return result;
            else throw new ArgumentException();
        }
        /// <summary>
        /// Funtion to switch an user in admin or simple user
        /// </summary>
        /// <param name="id">int id of user</param>
        /// <returns>bool : true if success</returns>
        public bool SwitchUser (int id)
        {
            Command command = new Command("SwitchAdmin",true);
            command.AddParameter("@IdUser", id);
            return Connection.ExecuteNonQuery(command) == 1;
        }
        /// <summary>
        /// Function to switch active an user
        /// </summary>
        /// <param name="id">int id of user</param>
        /// <returns>bool : true if success</returns>
        public bool SwitchActiveUser(int id)
        {
            Command command = new Command("SwitchActiveUser", true);
            command.AddParameter("@IdUser", id);
            return Connection.ExecuteNonQuery(command) == 1;
        }
    }
}
