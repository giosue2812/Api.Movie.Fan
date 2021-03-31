using Api.Movie.Fan.BackEnd.Core.Models.User;
using CL = Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Client.Models.Users;
using Api.Movie.Fan.BackEnd.Core.Models.Form.User;

namespace Api.Movie.Fan.BackEnd.Core.Mappers
{
    /// <summary>
    /// Mapper User
    /// </summary>
    public static class UserMapper
    {
        /// <summary>
        /// Function to convert Client Users to API UserShort
        /// </summary>
        /// <param name="entity">Client Users</param>
        /// <returns>API UserShort</returns>
        public static UserShort ToApi(this CL.Users.Users entity)
        {
            if (entity == null) return null;
            return new UserShort
            {
                Email = entity.Email,
                Pseudo = entity.Pseudo
            };
        }
        /// <summary>
        /// Function to convert API NewUserForm to Client NewUser
        /// </summary>
        /// <param name="newUser">Client NewUser</param>
        /// <returns>API NewUserForm</returns>
        public static CL.Users.NewUser ToClient(this NewUserForm newUser)
        {
            if (newUser == null) return null;
            return new CL.Users.NewUser
            {
                Email = newUser.Email,
                BirthDate = newUser.BirthDate,
                Password = newUser.Password
            };
        }
        /// <summary>
        /// Function to convert API LoginForm to Client UserLogin
        /// </summary>
        /// <param name="login">Client UserLogin</param>
        /// <returns>API LoginForm</returns>
        public static CL.Users.UserLogin ToClient(this LoginForm login)
        {
            if (login == null) return null;
            return new CL.Users.UserLogin
            {
                Email = login.Email,
                Password = login.Password
            };
        }
        /// <summary>
        /// Function to convert API UserResetPassword to Client UserResetPassword
        /// </summary>
        /// <param name="login">Client UserResetPassword</param>
        /// <returns>API UserResetPassword</returns>
        public static CL.Users.UserResetPassword ToClient(this UserResetPasswordForm userResetPassword)
        {
            if (userResetPassword == null) return null;
            return new CL.Users.UserResetPassword
            {
                Id = userResetPassword.Id,
                Email = userResetPassword.Email,
                Password = userResetPassword.Password
            };
        }
    }
}
