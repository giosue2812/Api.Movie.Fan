using Api.Movie.Fan.BackEnd.Core.Mappers;
using Api.Movie.Fan.BackEnd.Core.Models.Form.Notice;
using Api.Movie.Fan.BackEnd.Core.Models.Notice;
using Api.Movie.Fan.BackEnd.Core.ResponseError;
using Client.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class NoticeController : ControllerBase
    {
        private INoticeService Service;
        private IMovieService ServiceMovie;
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
        /// <returns>IActionResult</returns>
        #region Swagger
        [SwaggerOperation("Get All Notice")]
        [SwaggerResponse(200,"Return a lis of Notice",typeof(Notice))]
        [SwaggerResponse(500,"Server Error")]
        #endregion
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(Service.GetAll().Select(N => N.ToApi()));
        }
        /// <param name="id">int id of Notice</param>
        /// <returns>IActionResult</returns>
        #region Swagger
        [SwaggerOperation("Get Notice")]
        [SwaggerResponse(200,"Return one Notice",typeof(Notice))]
        [SwaggerResponse(500,"Server Error")]
        #endregion
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute, SwaggerParameter("Id of Notice",Required = true)]int id)
        {
            return Ok(Service.Get(id).ToApi());
        }
        #region Swagger
        [SwaggerOperation("Create Notice")]
        [SwaggerResponse(200,"Return id of Notice created",typeof(int))]
        [SwaggerResponse(400,"Form Is invalid",typeof(ExceptionResponse))]
        [SwaggerResponse(500,"Server Errror")]
        #endregion
        /// <param name="newNotice">NewNoticeForm</param>
        /// <returns>IActionResult</returns>
        [HttpPost]
        public IActionResult Create([FromBody,SwaggerRequestBody("Form new Notice",Required = true)] NewNoticeForm newNotice)
        {
            try
            {
                return Ok(Service.Create(newNotice.ToClient()));
            }
            catch(Exception)
            {
                return new BadRequestObjectResult(new ExceptionResponse() {Status = 400,Value = "Form is Invalid" });
            }
        }
        #region Swagger
        [SwaggerOperation("Update Notice")]
        [SwaggerResponse(200,"Return bool: true if success",typeof(bool))]
        [SwaggerResponse(400,"Form is invalid",typeof(ExceptionResponse))]
        [SwaggerResponse(500,"Server Error")]
        #endregion
        /// <param name="notice">Notice</param>
        /// <returns>IActionResult</returns>
        [HttpPut]
        public IActionResult Update([FromBody, SwaggerRequestBody("Notice", Required = true)] Notice notice)
        {
            try
            {
                return Ok(Service.Update(notice.ToClient()));
            }
            catch
            {
                return new BadRequestObjectResult(new ExceptionResponse() {Status = 400, Value = "Form is Invalid" });
            }
        }
        /// <param name="id">int id of Notice</param>
        /// <returns>IActionResult</returns>
        #region Swagger
        [SwaggerOperation("Delete Notice")]
        [SwaggerResponse(200,"Return bool : true if success",typeof(bool))]
        [SwaggerResponse(400,"Notice not exist",typeof(ExceptionResponse))]
        [SwaggerResponse(500,"Server Error")]
        #endregion
        [HttpDelete]
        public IActionResult Delete([FromRoute,SwaggerParameter("Id of Notice",Required = true)]int id)
        {
            try
            {
                return Ok(Service.Delete(id));
            }
            catch
            {
                return new BadRequestObjectResult(new ExceptionResponse() { Status = 400,Value = "Notice not exist"});
            }
        }
        /// <param name="id">int id of movie</param>
        /// <returns>IActionResult</returns>
        #region Swagger
        [SwaggerOperation("Get Notice by Movie")]
        [SwaggerResponse(200,"Return Movie with Notice",typeof(NoticeMovie))]
        [SwaggerResponse(500,"Server Error")]
        #endregion
        [HttpGet]
        [Route("GetNoticeByMovie/{id}")]
        public IActionResult GetNoticeByMovie([FromRoute,SwaggerParameter("Id of Movie",Required = true)]int id)
        {
            NoticeMovie noticeMovie = new NoticeMovie();
            noticeMovie.Movie = ServiceMovie.Get(id).ToApi();
            noticeMovie.NoticeByMovie = Service.GetNoticeByMovie(id).Select(NM => NM.ToApi());
            return Ok(noticeMovie);
        }
        /// <param name="id">int id of User</param>
        /// <returns>IActionResult</returns>
        #region
        [SwaggerOperation("Get Notice By User")]
        [SwaggerResponse(200,"Return notice by User",typeof(NoticeUser))]
        [SwaggerResponse(500,"Server Error")]
        #endregion
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
