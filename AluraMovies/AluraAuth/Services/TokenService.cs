using AluraAuth.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AluraAuth.Services
{
    public class TokenService
    {
        private readonly IConfiguration _configuration;

        public TokenService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Token CreateToken(IdentityUser<int> user)
        {
            Claim[] claims = new[]
            {
                new Claim("id", user.Id.ToString()),
                new Claim("username", user.UserName),
            };

            string privateKey = _configuration.GetValue<string>("Secret:PrivateKey");

            SymmetricSecurityKey key = new(Encoding.UTF8.GetBytes(privateKey));

            SigningCredentials signingCredentials = new(key, SecurityAlgorithms.HmacSha256);

            JwtSecurityToken token = new(
                claims: claims,
                signingCredentials: signingCredentials,
                expires: DateTime.UtcNow.AddHours(1));

            string tokenString = new JwtSecurityTokenHandler().WriteToken(token);

            return new Token(tokenString);
        }
    }
}
