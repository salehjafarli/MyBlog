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
        public UserManager(IUserRepository UserRepo)
        {
            this.UserRepo = UserRepo;
        }

        public IUserRepository UserRepo { get; }

        public async Task<bool> Login(LoginVM loginVM)
        {
            var user = await UserRepo.Login(loginVM.Username);
            return user.Password == loginVM.Password;
        }
    }
}
