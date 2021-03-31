using Client.Mappers;
using Client.Models.Persons;
using DAL_Movie.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Services
{
    /// <summary>
    /// class PersonService which implement a IPersonService
    /// </summary>
    public class PersonService : IPersonService
    {
        /// <summary>
        /// private variable of type IPersonRepository
        /// </summary>
        private IPersonRepository Repository;
        /// <summary>
        /// Constructor of PersonService
        /// </summary>
        /// <param name="repository">IPersonRepository</param>
        public PersonService(IPersonRepository repository)
        {
            Repository = repository;
        }
        /// <summary>
        /// Function to GetAll Person
        /// </summary>
        /// <returns>Person</returns>
        public IEnumerable<Person> GetAll()
        {
            return Repository.GetAll().Select(p => p.ToClient());
        }
        /// <summary>
        /// Function to Get one Person
        /// </summary>
        /// <returns>Person</returns>
        public Person Get(int id)
        {
            return Repository.Get(id).ToClient();
        }
        /// <summary>
        /// Function to create a new Person
        /// </summary>
        /// <returns>int id of Person created</returns>
        public int Create(NewPerson entity)
        {
            return Repository.Create(entity.ToDal());
        }
        /// <summary>
        /// Function to update an exist Person
        /// </summary>
        /// <param name="entity">NewPerson</param>
        /// <returns>bool: true if sucess</returns>
        public bool Update(Person entity)
        {
            return Repository.Update(entity.ToDal());
        }
        /// <summary>
        /// Function to get a person with movie
        /// </summary>
        /// <param name="id">int id of Person</param>
        /// <returns>IEnumerable PersonMovie</returns>
        public IEnumerable<PersonMovie> GetPersonMovie(int id)
        {
            return Repository.GetPersonMovie(id).Select(PM => PM.ToClient());
        }
    }
}
