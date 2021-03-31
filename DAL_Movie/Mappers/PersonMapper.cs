using DAL_Movie.Entities;
using DAL_Movie.ModelView.Person;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Movie.Mappers
{
    /// <summary>
    /// Mapper to map to Database to Dal
    /// </summary>
    public static class PersonMapper
    {
        /// <summary>
        /// Function to map a IDataRecord to Person
        /// </summary>
        /// <param name="record">IDataRecord</param>
        /// <returns>Person</returns>
        public static Person ToDalPerson(this IDataRecord record)
        {
            if (record == null) return null;
            return new Person
            {
                Id = (int)record["IdPerson"],
                FirstName = (string)record["FirstName"],
                LastName = (string)record["LastName"]
            };
        }
        /// <summary>
        /// Function to map a IDataRecord to PersonMovie
        /// </summary>
        /// <param name="record">IDataRecord</param>
        /// <returns>PersonMovie</returns>
        public static PersonMovie ToDalPersonMovie(this IDataRecord record)
        {
            if (record == null) return null;
            return new PersonMovie
            {
                Title = (string)record["Title"],
                Synopsis = (string)record["Synopsis"]
            };
        }
    }
}
