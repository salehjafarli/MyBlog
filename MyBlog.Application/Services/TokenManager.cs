using Microsoft.Extensions.Configuration;
using MyBlog.Application.Helpers;
using MyBlog.Application.Responses;
using MyBlog.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Application.Services
{
    public class TokenManager : ITokenService
    {
        public TokenManager(IUserService UserService,IConfiguration Configuration)
        {
            this.UserService = UserService;
            Secret = Configuration.GetSection("jwtsecret").Value;
        }
        public string Secret { get; set; }

        public IUserService UserService { get; }

        public async Task<TokenResponse> GetToken(LoginVM loginVM)
        {
            var res = await UserService.Login(loginVM);
            if (res)
            {
                var TokenResponse = new TokenResponse()
                {
                    AccessToken = GenerateJwtToken.Generate(Secret, 0.5),
                    RefreshToken = GenerateJwtToken.Generate(Secret, 1),
                };
                return TokenResponse;
            }
            else return null;
        }

        public Task<TokenResponse> GetToken(string RefreshToken)
        {
            
        }
    }
}
