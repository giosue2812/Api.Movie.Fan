using AP = Api.Movie.Fan.BackEnd.Core.Models;
using SEV = Client.Models.Persons;

namespace Api.Movie.Fan.BackEnd.Core.Mappers
{
    /// <summary>
    /// Mapper to map a Api model to client model
    /// Mapper to map a client model to Api model
    /// </summary>
    public static class PersonMapper
    {
        /// <summary>
        /// Function static to Convert an object Person from Client to API Person
        /// </summary>
        /// <param name="movie">Client Person</param>
        /// <returns>API Person</returns>
        public static AP.Persons.Person ToApi(this SEV.Person entity)
        {
            if (entity == null) return null;
            return new AP.Persons.Person
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName
            };
        }
        /// <summary>
        /// Function static to Convert an Object NewPerson from API to Client NewPerson
        /// </summary>
        /// <param name="person">API NewPerson</param>
        /// <returns>Client NewPerson</returns>
        public static SEV.NewPerson ToClient(this AP.Form.Persons.NewPersonForm newPerson)
        {
            if (newPerson == null) return null;
            return new SEV.NewPerson
            {
                FirstName = newPerson.FirstName,
                LastName = newPerson.LastName
            };
        }
        /// <summary>
        /// Function static to Convert an Object Person from API to Client Person
        /// </summary>
        /// <param name="person">API Person</param>
        /// <returns>Client Person</returns>
        public static SEV.Person ToClient(this AP.Persons.Person person)
        {
            if (person == null) return null;
            return new SEV.Person
            {
                Id = person.Id,
                FirstName = person.FirstName,
                LastName = person.LastName
            };
        }
        /// <summary>
        /// Function static to Convert an Object PersonMovie from Client to API MovieByPerson
        /// </summary>
        /// <param name="personMovie">Client PersonMovie</param>
        /// <returns>API MovieByPerson</returns>
        public static AP.Persons.MovieByPerson ToApi(this SEV.PersonMovie personMovie)
        {
            if (personMovie == null) return null;
            return new AP.Persons.MovieByPerson
            {
                Title = personMovie.Title,
                Synopsis = personMovie.Synopsis
            };
        }
        /// <summary>
        /// Function static to Convert an Object Person from Client to API Person (Short object)
        /// </summary>
        /// <param name="person">Client Person</param>
        /// <returns>API Person</returns>
        public static AP.Persons.Person ToApiShort(this SEV.Person person)
        {
            if (person == null) return null;
            return new AP.Persons.Person
            {
                FirstName = person.FirstName,
                LastName = person.LastName
            };
        }
    }
}
