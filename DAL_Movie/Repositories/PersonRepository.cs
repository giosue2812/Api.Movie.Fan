using DAL_Movie.Entities;
using DAL_Movie.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using DAL_Movie.Mappers;
using Tool.Connection.DB;
using DAL_Movie.ModelView.Person;

namespace DAL_Movie.Repositories
{
    /// <summary>
    /// Repository of Person
    /// </summary>
    public class PersonRepository : RepositoryBase<Person, int>, IPersonRepository
    {
        /// <summary>
        /// Function to get all Person
        /// </summary>
        /// <returns>IEnumerable of Person</returns>
        public override IEnumerable<Person> GetAll()
        {
            Command command = new Command("SELECT * FROM V_Person");
            return Connection.ExecuteReader(command,(p)=>p.ToDalPerson());

        }
        /// <summary>
        /// Function to get one Person
        /// </summary>
        /// <param name="id">int id of Person</param>
        /// <returns>Person</returns>
        public override Person Get(int id)
        {
            Command command = new Command("SELECT * FROM V_Person WHERE IdPerson = @Id");
            command.AddParameter("@Id", id);
            return Connection.ExecuteReader(command, (p) => p.ToDalPerson()).SingleOrDefault();
        }
        /// <summary>
        /// Function to create a new Person
        /// </summary>
        /// <param name="entity">Entity Person</param>
        /// <returns>int id of Person created</returns>
        public override int Create(Person entity)
        {
            Command command = new Command("AddPerson", true);
            command.AddParameter("@LastName", entity.LastName);
            command.AddParameter("@FirstName", entity.FirstName);
            return (int)Connection.ExecuteScalar(command);
        }
        /// <summary>
        /// Function to update an Exist Person
        /// </summary>
        /// <param name="entity">Entity Person</param>
        /// <returns>bool: true if sucess</returns>
        public bool Update(Person entity)
        {
            Command command = new Command("UpdatePerson",true);
            command.AddParameter("@IdPerson", entity.Id);
            command.AddParameter("@LastName", entity.LastName);
            command.AddParameter("@FirstName", entity.FirstName);
            return Connection.ExecuteNonQuery(command) == 1;
        }
        /// <summary>
        /// Function to get a PersonMovie
        /// </summary>
        /// <param name="id">int id of Person</param>
        /// <returns>PersonMovie</returns>
        public IEnumerable<PersonMovie> GetPersonMovie(int id)
        {
            Command command = new Command("PersonMovie", true);
            command.AddParameter("@IdPerson", id);
            return Connection.ExecuteReader(command, (PM) => PM.ToDalPersonMovie());
        }
        /// <summary>
        /// Function to get a list of movie by person (Producteur or Writer)
        /// </summary>
        /// <param name="id">int id of Producteur or Writer</param>
        /// <returns>PersonProdWritMovie</returns>
        public IEnumerable<PersonProdWritMovie>GetPersonProdWritMovies(int id)
        {
            Command command = new Command("PersonProdWritMovie", true);
            command.AddParameter("@IdPerson", id);
            return Connection.ExecuteReader(command, (PM) => PM.ToDalPersonProdWriteMovie());
        }
    }
}
