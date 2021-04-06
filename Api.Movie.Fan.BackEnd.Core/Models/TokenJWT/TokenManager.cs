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

            Claim[] claims = new[]
            {
                new Claim(ClaimTypes.Email,userShort.Email),
                new Claim("Pseudo",userShort.Pseudo),
                new Claim(ClaimTypes.Role,userShort.IsAdmin ? "Admin":"User")
            };

            JwtSecurityToken token = new JwtSecurityToken(
                    issuer: Secret,
                    audience: Audience,
                    claims: claims,
                    expires: DateTime.Now.AddDays(1),
                    signingCredentials: credentials);

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            return tokenHandler.WriteToken(token);
        }
    }
}
