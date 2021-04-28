using Client.Models.Persons;
using DAL = DAL_Movie;


namespace Client.Mappers
{
    /// <summary>
    /// Mapper to map a Client model to DAL model.
    /// Mapper to map a DAL model to Client model
    /// </summary>
    public static class MapperPerson
    {
        /// <summary>
        /// Functio static to Convert an object CL.Entities.Person from Dal to Client Person
        /// </summary>
        /// <param name="entity">DAL CL.Entities.Person</param>
        /// <returns>Client Person</returns>
        public static Person ToClient(this DAL.Entities.Person entity)
        {
            if (entity == null) return null;
            return new Person
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName
            };
        }
        /// <summary>
        /// Functio static to Convert an object Person from Client to Dal CL.Entities.Person from Dal
        /// </summary>
        /// <param name="entity">Client Person</param>
        /// <returns>DAL CL.Entities.Person </returns>
        public static DAL.Entities.Person ToDal(this Person entity)
        {
            if (entity == null) return null;
            return new DAL.Entities.Person
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName
            };
        }
        /// <summary>
        /// Functio static to Convert an object NewPerson from Client to Dal CL.Entities.Person from Dal
        /// </summary>
        /// <param name="entity">Client NewPerson</param>
        /// <returns>DAL CL.Entities.Person </returns>
        public static DAL.Entities.Person ToDal(this NewPerson entity)
        {
            if (entity == null) return null;
            return new DAL.Entities.Person
            {
                FirstName = entity.FirstName,
                LastName = entity.LastName
            };
        }
        /// <summary>
        /// Function static to Convert an object DAL.ModelView.Person.PersonMovie from DAL to Client PersonMovie
        /// </summary>
        /// <param name="entity">DAL DAL.ModelView.Person.PersonMovie</param>
        /// <returns>Client PersonMovie</returns>
        public static PersonMovie ToClient(this DAL.ModelView.Person.PersonMovie entity)
        {
            if (entity == null) return null;
            return new PersonMovie
            {
                Title = entity.Title,
                Synopsis = entity.Synopsis,
                Role = entity.Role
            };
        }
        /// <summary>
        /// Function static to convert an object DAL PersonProdWritMovie to Client PersonProdWritMovie
        /// </summary>
        /// <param name="entity">DAL PersonProdWritMovie</param>
        /// <returns>PersonProdWritMovie</returns>
        public static PersonProdWritMovie ToClient(this DAL.ModelView.Person.PersonProdWritMovie entity)
        {
            if (entity == null) return null;
            return new PersonProdWritMovie
            {
                Title = entity.Title,
                Synopsis = entity.Synopsis
            };
        }
    }
}
