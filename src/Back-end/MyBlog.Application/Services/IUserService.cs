using MyBlog.Application.Responses;
using MyBlog.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Application.Services
{
    public interface IUserService
    {
        public Task<TokenResponse> Login(LoginVM loginVM);
        public Task<TokenResponse> RenewToken(string RefreshToken);
    }
}
