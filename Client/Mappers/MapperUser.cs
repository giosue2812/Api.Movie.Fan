using Client.Models.Users;
using DAL = DAL_Movie;

namespace Client.Mappers
{
    /// <summary>
    /// Mapper for user
    /// </summary>
    public static class MapperUser
    {
        /// <summary>
        /// Function to convert DAL Users to Client Users
        /// </summary>
        /// <param name="entity">DAL Users</param>
        /// <returns>Client Users</returns>
        public static Users ToClient(this DAL.Entities.Users entity)
        {
            if (entity == null) return null;
            return new Users
            {
                Id = entity.Id,
                BirthDate = entity.BirthDate,
                Email = entity.Email,
                Pseudo = entity.Pseudo,
                IsAdmin = entity.IsAdmin,
                IsActive = entity.IsActive
            };
        }
        /// <summary>
        /// Function to convert Client NewUser to DAL Users
        /// </summary>
        /// <param name="newUser">Client NewUser</param>
        /// <returns>DAL Users</returns>
        public static DAL.Entities.Users ToDal(this NewUser newUser)
        {
            if (newUser == null) return null;
            return new DAL.Entities.Users
            {
                Email = newUser.Email,
                BirthDate = newUser.BirthDate,
                Password = newUser.Password
            };
        }
        /// <summary>
        /// Function to convert Client  to Client Users
        /// </summary>
        /// <param name="login">UserLogin</param>
        /// <returns>UserLogin</returns>
        public static DAL.Entities.Users ToDal(this UserLogin users)
        {
            if (users == null) return null;
            return new DAL.Entities.Users
            {
                Email = users.Email,
                Password = users.Password
            };
        }
        /// <summary>
        /// Function to convert a Client UserResetPassword to DAL Users
        /// </summary>
        /// <param name="userResetPassword">UserResetPassword</param>
        /// <returns>DAL Users</returns>
        public static DAL.Entities.Users ToDal(this UserResetPassword userResetPassword)
        {
            if (userResetPassword == null) return null;
            return new DAL.Entities.Users
            {
                Email = userResetPassword.Email,
                Password = userResetPassword.Password,
                Id = userResetPassword.Id
            };
        }
    }
}
