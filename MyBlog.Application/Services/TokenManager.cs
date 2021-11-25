using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using MyBlog.Application.Helpers;
using MyBlog.Application.Responses;
using MyBlog.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Application.Services
{
    public class TokenManager : ITokenService
    {
        public TokenManager(IConfiguration Configuration)
        {
            Secret = Configuration.GetSection("jwtsecret").Value;
        }
        public string Secret { get; set; }


        public Task<TokenResponse> GetToken(LoginVM loginVM)
        {
            var tokenBuilder = new JwtTokenBuilder().SetClaims("username", loginVM.Username);
            var TokenResponse = new TokenResponse()
            {
                AccessToken = tokenBuilder.Generate(Secret, 0.5).GetToken(),
                RefreshToken = tokenBuilder.Generate(Secret, 1).GetToken(),
            };
            return Task.FromResult(TokenResponse);
        }

        public Task<TokenResponse> GetToken(string RefreshToken)
        {
            var res = JwtTokenValidator.Validate(RefreshToken, Secret, out SecurityToken validatedToken);
            string username = ((JwtSecurityToken)validatedToken).Claims.FirstOrDefault(x => x.Type == "username").Value;
            if (res)
            {
                var tokenBuilder = new JwtTokenBuilder().SetClaims("username", username);
                var TokenResponse = new TokenResponse()
                {
                    AccessToken = tokenBuilder.Generate(Secret, 0.5).GetToken(),
                    RefreshToken = tokenBuilder.Generate(Secret, 1).GetToken(),
                };
                return Task.FromResult(TokenResponse);
            }
            else return null;
        }
    }
}
