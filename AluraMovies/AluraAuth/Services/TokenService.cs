using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AluraAuth.Services
{
    public class TokenService
    {
        public Token CreateToken(IdentityUser<int> user)
        {
            Claim[] claims = new[]
            {
                new Claim("id", user.Id.ToString()),
                new Claim("username", user.UserName),
            };

            SymmetricSecurityKey key = new(Encoding.UTF8.GetBytes("9F92ECC234C304535E11291DF26BA6D995ED7CF7694FBED030EED9130A2489C8"));

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
