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
        public Task<bool> Login(LoginVM loginVM);
    }
}
