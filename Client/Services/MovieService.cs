using Client.Mappers;
using Client.Models.Movie;
using DAL_Movie.Repositories;
using DAL_Movie.Repositories.Interfaces;
using DAL = DAL_Movie.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Client.Services
{
    /// <summary>
    /// class MovieService which implement a IMovieService
    /// </summary>
    public class MovieService : IMovieService
    {
        /// <summary>
        /// private variable of type IMovieRepository
        /// </summary>
        private IMovieRepository Repository;
        /// <summary>
        /// Constructor of MovieService
        /// </summary>
        /// <param name="repository">IMovieRepository</param>
        public MovieService(IMovieRepository repository)
        {
            Repository = repository;
        }
        /// <summary>
        /// Function to Get all movie
        /// </summary>
        /// <returns>IEnumerable Movie</returns>
        public IEnumerable<Movie> GetAll()
        {
            return Repository.GetAll().Select(m => m.ToClient());
        }
        /// <summary>
        /// Function to Get one movie
        /// </summary>
        /// <param name="id">int id of movie</param>
        /// <returns>Movie</returns>
        public Movie Get(int id)
        {
            return Repository.Get(id).ToClient();
        }
        /// <summary>
        /// Function to Get all Movie Director and Writer
        /// </summary>
        /// <returns>MovieDirectorWriter</returns>
        public IEnumerable<MovieDirectorWriter> GetMovieDirectorWriter()
        {
            return Repository.GetMovieDirectorWriter().Select(m => m.ToClient());
        }
        /// <summary>
        /// Function to Get one Movie Director and Writer
        /// </summary>
        /// <returns>MovieDirectorWriter</returns>
        public MovieDirectorWriter GetMovieDirectorWriter(int id)
        {
            return Repository.GetMovieDirectorWriter(id).ToClient();
        }
        /// <summary>
        /// Function to Get one Movie with Casting
        /// </summary>
        /// <returns>MovieCasting</returns>
        public IEnumerable<MovieCasting> GetMovieCasting(int id)
        {
            return Repository.GetMovieCasting(id).Select(m => m.ToClient());
        }
        /// <summary>
        /// Create a new movie
        /// </summary>
        /// <param name="entity">NewMovie</param>
        /// <returns>int of movie created</returns>
        public int Create(NewMovie entity)
        {
            return Repository.Create(entity.ToDal());
        }
        /// <summary>
        /// Function to addCasting
        /// </summary>
        /// <param name="entity">AddCasting</param>
        /// <returns>int of created casting</returns>
        public int AddCasting(AddCasting entity)
        {
            return Repository.AddCasting(entity.ToDal());
        }
        /// <summary>
        /// Update an exist movie
        /// </summary>
        /// <param name="entity">Movie</param>
        /// <returns>bool : true if success</returns>
        public bool Update(Movie entity)
        {
            return Repository.Update(entity.ToDal());
        }
    }
}
