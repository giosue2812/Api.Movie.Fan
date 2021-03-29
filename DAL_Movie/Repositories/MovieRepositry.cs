using DAL_Movie.Entities;
using DAL_Movie.Mappers;
using DAL_Movie.ModelView;
using DAL_Movie.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tool.Connection.DB;

namespace DAL_Movie.Repositories
{
    /// <summary>
    /// Movie Repository Request to database
    /// </summary>
    public class MovieRepositry : RepositoryBase<Movie, int>,IMovieRepository
    {
        public MovieRepositry():base()
        {

        }
        /// <summary>
        /// Function to get all movies
        /// </summary>
        /// <returns>IEnumerblae of Movie</returns>
        public override IEnumerable<Movie> GetAll()
        {
            Command command = new Command("SELECT * FROM V_Movies");
            return Connection.ExecuteReader(command, (m) => m.ToMovies());
        }
        /// <summary>
        /// Function to get one movie
        /// </summary>
        /// <param name="id">int id of movie</param>
        /// <returns>Movie</returns>
        public override Movie Get(int id)
        {
            Command command = new Command("SELECT * FROM V_Movies WHERE IdMovie = @IdMovie");
            command.AddParameter("@IdMovie", id);
            return Connection.ExecuteReader<Movie>(command, (m) => m.ToMovies()).SingleOrDefault();
        }
        /// <summary>
        /// Function to create a new movie
        /// </summary>
        /// <param name="entity">New Movie</param>
        /// <returns>int id of movie created</returns>
        public override int Create(Movie entity)
        {
            Command command = new Command("AddMovie",true);
            command.AddParameter("@Title", entity.Title);
            command.AddParameter("@Synopsis", entity.Synopsis);
            command.AddParameter("@Director", entity.Director);
            command.AddParameter("@Writer", entity.Writer);
            command.AddParameter("YearRelease", entity.YearRelease);
            return (int)Connection.ExecuteNonQuery(command);
        }
        /// <summary>
        /// Function to update a existing movie
        /// </summary>
        /// <param name="entity">Update Movie</param>
        /// <returns>bool true or false</returns>
        public override bool Update(Movie entity)
        {
            Command command = new Command("UpdateMovie", true);
            command.AddParameter("@IdMovie", entity.Id);
            command.AddParameter("@Title", entity.Title);
            command.AddParameter("@YearRelease", entity.YearRelease);
            command.AddParameter("@Synopsis", entity.Synopsis);
            command.AddParameter("@Director", entity.Director);
            command.AddParameter("Writer", entity.Writer);
            return Connection.ExecuteNonQuery(command) == 1;
        }
        /// <summary>
        /// Function to get a list of movie with a Director and Writer
        /// </summary>
        /// <returns>IEnumerable of MovieDirectorWriter</returns>
        public IEnumerable<MovieDirectorWriter> GetMovieDirectorWriter()
        {
            Command command = new Command("SELECT * FROM Movie_With_Dirctor_Writer_Name");
            return Connection.ExecuteReader(command, (M) => M.ToMovieDirectorWriter());
        }
        /// <summary>
        /// Function to get one movie with Director and Writer
        /// </summary>
        /// <param name="id">int id of movie</param>
        /// <returns>MovieDirectorWriter</returns>
        public MovieDirectorWriter GetMovieDirectorWriter(int id)
        {
            Command command = new Command("SELECT * FROM Movie_With_Dirctor_Writer_Name WHERE IdMovie = @Id");
            command.AddParameter("@Id", id);
            return Connection.ExecuteReader(command, (m) => m.ToMovieDirectorWriter()).SingleOrDefault();
        }
        /// <summary>
        /// Function to get a list of movie with a casting(Actor and role)
        /// </summary>
        /// <returns>IEnumerable of MovieCasting</returns>
        public IEnumerable<MovieCasting> GetMovieCasting()
        {
            Command command = new Command("SELECT * FROM Movie_Casting");
            return Connection.ExecuteReader(command, (M) => M.ToMovieCasting());
        }
        /// <summary>
        /// Function to get a list of one movie with a casting(Actor and Role)
        /// </summary>
        /// <param name="id">int id of movie</param>
        /// <returns></returns>
        public IEnumerable<MovieCasting> GetMovieCasting(int id)
        {
            Command command = new Command("SELECT * FROM Movie_Casting WHERE IdMovie = @Id");
            command.AddParameter("@Id", id);
            return Connection.ExecuteReader(command, (m) => m.ToMovieCasting());
        }
    }
}
