using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Application.Helpers
{
    public class JwtTokenBuilder
    {
        private string Token { get; set; }
        private ClaimsIdentity Claims { get; set; } = new ClaimsIdentity();
        public JwtTokenBuilder Generate(string Secret,double ExpirationMinute)
        {
            // generate token that is valid for 7 days
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = Claims,
                Expires = DateTime.UtcNow.AddMinutes(ExpirationMinute),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            Token = tokenHandler.WriteToken(token);
            return this;
        }


        public JwtTokenBuilder SetClaims(string type,string value)
        {
            Claims.AddClaim(new Claim(type,value));
            return this;
        }

        public string GetToken()
        {
            return Token;
        }
    }
}
