using Api.Movie.Fan.BackEnd.Core.Mappers;
using Api.Movie.Fan.BackEnd.Core.Models.Form.User;
using Api.Movie.Fan.BackEnd.Core.Models.TokenJWT;
using Api.Movie.Fan.BackEnd.Core.Models.User;
using Client.Models.Users;
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
    /// Controller User
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        /// <summary>
        /// Private Property IUserService
        /// </summary>
        private IUserService Service;
        /// <summary>
        /// 
        /// </summary>
        private IAdminService AdminService;
        private TokenManager TokenManager;
        /// <summary>
        /// Constructor User controller
        /// </summary>
        /// <param name="service">IUserService</param>
        public UserController(IUserService service,IAdminService adminService,TokenManager tokenManager)
        {
            Service = service;
            AdminService = adminService;
            TokenManager = tokenManager;
        }
        /// <summary>
        /// Function to get all user
        /// </summary>
        /// <returns>IActionResult</returns>
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(Service.GetAll().Select(u => u.ToApi()));
        }
        /// <summary>
        /// Function to get one user
        /// </summary>
        /// <param name="id">int id of user</param>
        /// <returns>IActionResult</returns>
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(Service.Get(id).ToApi());
        }
        /// <summary>
        /// Function to register user
        /// </summary>
        /// <param name="newUser">NewUserForm</param>
        /// <returns>IActionResult</returns>
        [HttpPost]
        public IActionResult Register(NewUserForm newUser)
        {
            try
            {
                return Ok(Service.Create(newUser.ToClient()));
            }
            catch
            {
                return new BadRequestObjectResult(new { error = "Form is invalid" });
            }
        }
        /// <summary>
        /// Function Login user
        /// </summary>
        /// <param name="login">LoginForm</param>
        /// <returns>IActionResult</returns>
        [HttpPost]
        [Route("login")]
        public IActionResult Login(LoginForm login)
        {
            //try
            //{
                UserShort userShort = Service.Login(login.ToClient()).ToApi();
                TokenManager.GenerateJWT(userShort);
                return Ok(userShort);
            //}
            //catch
            //{
            //    return new BadRequestObjectResult(new { error = "Form is invalid" });
            //}
        }
        /// <summary>
        /// Funciton to switch an user in Admin or simple user
        /// </summary>
        /// <param name="id">int id of user</param>
        /// <returns>IActionResult</returns>
        [HttpPut]
        [Route("SwitchUser/{id}")]
        public IActionResult SwitchUser(int id)
        {
            return Ok(AdminService.SwitchUser(id));
        }
        /// <summary>
        /// Funciton to switch an user in active or disabeld
        /// </summary>
        /// <param name="id">int id of user</param>
        /// <returns>IActionResult</returns>
        [HttpPut]
        [Route("SwitchActiveUser/{id}")]
        public IActionResult SwitchActiveUser(int id)
        {
            return Ok(AdminService.SwitchActiveUser(id));
        }
        /// <summary>
        /// Funciton to reset password
        /// </summary>
        /// <param name="id">int id of user</param>
        /// <returns>IActionResult</returns>
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
                return new BadRequestObjectResult(new { error="Form is invalid" });
            }
        }
    }
}
