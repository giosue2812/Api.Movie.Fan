using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.Form.User
{
    /// <summary>
    /// Class to User Reset Password Form
    /// </summary>
    [SwaggerSchema(Required = new[] {"User Reset Password Form"})]
    public class UserResetPasswordForm
    {
        [SwaggerSchema("Id of User")]
        [HiddenInput(DisplayValue = true)]
        public int Id { get; set; }
        [SwaggerSchema("Email of User")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [SwaggerSchema("Password of User")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
