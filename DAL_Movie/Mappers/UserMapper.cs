using DAL_Movie.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Movie.Mappers
{
    /// <summary>
    /// Mapper for user
    /// </summary>
    public static class UserMapper
    {
        /// <summary>
        /// Function to convert IDataRecord to DAL Users
        /// </summary>
        /// <param name="record">IDataRecord</param>
        /// <returns>Users</returns>
        public static Users ToDalUser(this IDataRecord record)
        {
            if (record == null) return null;
            return new Users
            {
                Id = (int)record["Id"],
                Email = (string)record["Email"],
                BirthDate = (DateTime)record["BirthDate"],
                Password = null,
                Pseudo = (string)record["Pseudo"],
                IsActive = (bool)record["IsActive"],
                IsAdmin = (bool)record["IsAdmin"]
            };
        }
    }
}
