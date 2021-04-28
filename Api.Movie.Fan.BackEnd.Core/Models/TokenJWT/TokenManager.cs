using Api.Movie.Fan.BackEnd.Core.Models.User;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Api.Movie.Fan.BackEnd.Core.Models.TokenJWT
{
    public class TokenManager
    {
        public string Secret { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        private readonly IConfiguration Config;
        public TokenManager(IConfiguration config)
        {
            Config = config;
            Secret = Config.GetValue<string>("Token:Secret");
            Issuer = Config.GetValue<string>("Token:Issuer");
            Audience = Config.GetValue<string>("Token:Audience");
        }
        public string GenerateJWT(UserShort userShort)
        {
            if (userShort.Email is null) throw new ArgumentNullException();
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Secret));
            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha512Signature);

            SecurityTokenDescriptor tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("Id",userShort.Id.ToString()),
                    new Claim(ClaimTypes.Email, userShort.Email),
                    new Claim("Pseudo",userShort.Pseudo),
                    new Claim(ClaimTypes.Role, userShort.IsAdmin ? "admin" : "user")
                }),
                Issuer = Issuer,
                Audience = Audience,
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = credentials
            };
            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
