using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MyBlog.Application.Services;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Application.Middlewares
{
    public class JWTMiddleware : IMiddleware
    {
        public JWTMiddleware(IUserService UserService,IConfiguration Configuration)
        {
            this.UserService = UserService;
            this.Configuration = Configuration;
        }
        private readonly RequestDelegate next;

        public JWTMiddleware(RequestDelegate next)
        {
            this.next = next;
        }
        public IUserService UserService { get; }
        public IConfiguration Configuration { get; }

        public async Task InvokeAsync(HttpContext context)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();


            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(Configuration.GetSection("jwtsecret").Value);
            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
                // set clockskew to zero so tokens expire exactly at token expiration time (instead of 5 minutes later)
                ClockSkew = TimeSpan.Zero
            }, out SecurityToken validatedToken);

            var jwtToken = (JwtSecurityToken)validatedToken;

            // attach user to context on successful jwt validation

            await next(context);
        }
    }
}
