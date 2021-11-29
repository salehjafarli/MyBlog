using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MyBlog.Application.Helpers;
using MyBlog.Application.Services;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Application.Middlewares
{
    public class JWTMiddleware
    {
        private readonly RequestDelegate next;

        public JWTMiddleware(RequestDelegate next)
        {
            this.next = next;

        }


        public async Task InvokeAsync(HttpContext context,IConfiguration Configuration)
        {
            var token = context.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last();
            var res = JwtTokenValidator.Validate(token,Configuration.GetSection("jwtsecret").Value,out SecurityToken securityToken);
            if (res)
            {
                var jwtToken = (JwtSecurityToken)securityToken;
                string username = jwtToken.Claims.FirstOrDefault(x => x.Type == "username").Value;
                context.Items["username"] = username;
            }
            // attach user to context on successful jwt validation
            await next(context);
        }
    }
}
