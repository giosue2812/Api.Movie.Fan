using Api.Movie.Fan.BackEnd.Core.Mappers;
using Api.Movie.Fan.BackEnd.Core.Models.Form.User;
using Api.Movie.Fan.BackEnd.Core.Models.TokenJWT;
using Api.Movie.Fan.BackEnd.Core.Models.User;
using Api.Movie.Fan.BackEnd.Core.ResponseError;
using Client.Models.Users;
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
    /// <summary>
    /// Controller User
    /// </summary>
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService Service;
        private IAdminService AdminService;
        private TokenManager TokenManager;
        /// <param name="service">IUserService</param>
        /// <param name="adminService">IAdminService</param>
        /// <param name="tokenManager">TokenManager</param>
        public UserController(IUserService service,IAdminService adminService,TokenManager tokenManager)
        {
            Service = service;
            AdminService = adminService;
            TokenManager = tokenManager;
        }
        /// <returns>IActionResult</returns>
        #region Swagger
        [SwaggerOperation("Get All User")]
        [SwaggerResponse(200,"Return list of User",typeof(UserShort))]
        [SwaggerResponse(500,"Server Error")]
        #endregion
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(Service.GetAll().Select(u => u.ToApi()));
        }
        /// <param name="id">int id of user</param>
        /// <returns>IActionResult</returns>
        #region Swagger
        [SwaggerOperation("Get User")]
        [SwaggerResponse(200,"Return an User",typeof(UserShort))]
        [SwaggerResponse(500,"Server Error")]
        #endregion
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get([FromRoute,SwaggerParameter("Id of User",Required = true)]int id)
        {
            return Ok(Service.Get(id).ToApi());
        }
        /// <param name="newUser">NewUserForm</param>
        /// <returns>IActionResult</returns>
        #region Swagger
        [SwaggerOperation("Register")]
        [SwaggerResponse(200,"Id of User created",typeof(int))]
        [SwaggerResponse(400,"Form is invalid",typeof(ExceptionResponse))]
        [SwaggerResponse(500,"Server Error")]
        #endregion
        [HttpPost]
        public IActionResult Register([FromBody,SwaggerRequestBody("Form new User",Required = true)]NewUserForm newUser)
        {
            try
            {
                return Ok(Service.Create(newUser.ToClient()));
            }
            catch
            {
                return new BadRequestObjectResult(new ExceptionResponse() { Status = 400,Value = "Form is Invalid" });
            }
        }
        /// <param name="login">LoginForm</param>
        /// <returns>IActionResult</returns>
        #region Swagger
        [SwaggerOperation("Login")]
        [SwaggerResponse(200,"Login Form",typeof(UserShort))]
        [SwaggerResponse(400,"Password or Email is invalid",typeof(ExceptionResponse))]
        [SwaggerResponse(500,"Server Error")]
        #endregion
        [HttpPost]
        [Route("login")]
        public IActionResult Login([FromBody,SwaggerRequestBody("Form login",Required = true)]LoginForm login)
        {
            try
            {
                UserShort userShort = Service.Login(login.ToClient()).ToApi();
                string Token = TokenManager.GenerateJWT(userShort).ToString();
                return Ok(Token);
            }
            catch(Exception)
            {
                return new BadRequestObjectResult(new ExceptionResponse() {Status = 400,Value = "Password or Email is invalid" });
            }
        }
        /// <param name="id">int id of user</param>
        /// <returns>IActionResult</returns>
        #region Swagger
        [SwaggerOperation("Switch User in Admin or User")]
        [SwaggerResponse(200,"bool : true if success",typeof(bool))]
        [SwaggerResponse(500,"Server Error")]
        #endregion
        [HttpPut]
        [Route("SwitchUser/{id}")]
        public IActionResult SwitchUser([FromRoute,SwaggerParameter("Id of User",Required = true)]int id)
        {
            return Ok(AdminService.SwitchUser(id));
        }

        /// <param name="id">int id of user</param>
        /// <returns>IActionResult</returns>
        #region Swagger
        [SwaggerOperation("Switch Active User")]
        [SwaggerResponse(200,"bool: true if succeess",typeof(bool))]
        [SwaggerResponse(500,"Server Error")]
        #endregion
        [HttpPut]
        [Route("SwitchActiveUser/{id}")]
        public IActionResult SwitchActiveUser([FromRoute,SwaggerParameter("Id of User",Required = true)]int id)
        {
            return Ok(AdminService.SwitchActiveUser(id));
        }
        /// <param name="id">int id of user</param>
        /// <returns>IActionResult</returns>
        #region Swagger
        [SwaggerOperation("Reset Password")]
        [SwaggerResponse(200,"bool: true if success",typeof(bool))]
        [SwaggerResponse(400,"Email is not valid",typeof(ExceptionResponse))]
        [SwaggerResponse(500,"Server Error")]
        #endregion
        [HttpPut]
        [Route("ResetPassword")]
        public IActionResult ResetPassword(UserResetPasswordForm userResetPassword)
        {
            try
            {
                return Ok(Service.ResetPaswword(userResetPassword.ToClient()));
            }
            catch
            {
                return new BadRequestObjectResult(new ExceptionResponse() {Status = 400,Value = "Email is not valid" });
            }
        }
    }
}
