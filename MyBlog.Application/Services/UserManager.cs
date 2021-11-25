using MyBlog.Application.Helpers;
using MyBlog.Application.Responses;
using MyBlog.Application.ViewModels;
using MyBlog.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Application.Services
{
    public class UserManager : IUserService
    {
        public UserManager(IUserRepository UserRepo,ITokenService TokenService)
        {
            this.UserRepo = UserRepo;
            this.TokenService = TokenService;
        }

        public IUserRepository UserRepo { get; }
        public ITokenService TokenService { get; }

        public async Task<TokenResponse> Login(LoginVM loginVM)
        {
            var user = await UserRepo.Login(loginVM.Username);
            var hashedPass = PasswordHasher.ComputeSha256Hash(loginVM.Password);
            var result =  user.Password == hashedPass;
            if (result)
            {
                var tokenModel = await TokenService.GetToken(loginVM);
                return tokenModel;
            }
            else return null;

        }
        public async Task<TokenResponse> RenewToken(string RefreshToken)
        {
            return await TokenService.GetToken(RefreshToken);
        }

    }
}
