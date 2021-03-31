using Api.Movie.Fan.BackEnd.Core.Mappers;
using Api.Movie.Fan.BackEnd.Core.Models.Form.Notice;
using Api.Movie.Fan.BackEnd.Core.Models.Notice;
using Client.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Controllers
{
    /// <summary>
    /// Controller Notice
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class NoticeController : ControllerBase
    {
        /// <summary>
        /// Private Property of type INoticeService
        /// </summary>
        private INoticeService Service;
        /// <summary>
        /// Private Property of type IMovieService
        /// </summary>
        private IMovieService ServiceMovie;
        /// <summary>
        /// Private Property of type IUserService
        /// </summary>
        private IUserService ServiceUser;
        /// <summary>
        /// Constructor of Controller Notice
        /// </summary>
        /// <param name="service">INoticeService</param>
        /// <param name="serviceMovie">IMovieService</param>
        /// <param name="serviceUser">IUserService</param>
        public NoticeController(INoticeService service,IMovieService serviceMovie,IUserService serviceUser)
        {
            Service = service;
            ServiceMovie = serviceMovie;
            ServiceUser = serviceUser;
        }
        /// <summary>
        /// Function to get all Notice
        /// </summary>
        /// <returns>IActionResult</returns>
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(Service.GetAll().Select(N => N.ToApi()));
        }
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(Service.Get(id).ToApi());
        }
        /// <summary>
        /// Function to create a new Notice
        /// </summary>
        /// <param name="newNotice">NewNoticeForm</param>
        /// <returns>IActionResult</returns>
        [HttpPost]
        public IActionResult Create(NewNoticeForm newNotice)
        {
            try
            {
                return Ok(Service.Create(newNotice.ToClient()));
            }
            catch
            {
                return new BadRequestObjectResult(new { error = "Form is invalid" });
            }
        }
        /// <summary>
        /// Function to update an existing notice
        /// </summary>
        /// <param name="notice">Notice</param>
        /// <returns>IActionResult</returns>
        [HttpPut]
        public IActionResult Update(Notice notice)
        {
            try
            {
                return Ok(Service.Update(notice.ToClient()));
            }
            catch
            {
                return new BadRequestObjectResult(new { error = "Form is invald" });
            }
        }
        /// <summary>
        /// Function to delete a notice
        /// </summary>
        /// <param name="id">int id of Notice</param>
        /// <returns>IActionResult</returns>
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                return Ok(Service.Delete(id));
            }
            catch
            {
                return BadRequest();
            }
        }
        /// <summary>
        /// Function to get Movie with Notices
        /// </summary>
        /// <param name="id">int id of movie</param>
        /// <returns>IActionResult</returns>
        [HttpGet]
        [Route("GetNoticeByMovie/{id}")]
        public IActionResult GetNoticeByMovie(int id)
        {
            NoticeMovie noticeMovie = new NoticeMovie();
            noticeMovie.Movie = ServiceMovie.Get(id).ToApi();
            noticeMovie.NoticeByMovie = Service.GetNoticeByMovie(id).Select(NM => NM.ToApi());
            return Ok(noticeMovie);
        }
        [HttpGet]
        [Route("GetNoticeByUser/{id}")]
        public IActionResult GetNoticeByUser(int id)
        {
            NoticeUser noticeUser = new NoticeUser();
            noticeUser.User = ServiceUser.Get(id).ToApi();
            noticeUser.NoticeByUsers = Service.GetNoticeByUsers(id).Select(NU => NU.ToApi());
            return Ok(noticeUser);
        }
    }
}
