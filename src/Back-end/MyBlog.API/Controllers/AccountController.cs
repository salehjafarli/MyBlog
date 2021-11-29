using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Application.Services;
using MyBlog.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        public AccountController(IUserService userService)
        {
            UserService = userService;
        }

        public IUserService UserService { get; }
        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            var res = await UserService.Login(loginVM);
            return res is null ? NotFound() : Ok(res);
        }
        [HttpPost]
        [Route("{RefreshToken}")]
        public async Task<IActionResult> RenewToken(string RefreshToken)
        {
            var res = await UserService.RenewToken(RefreshToken);
            return res is null ? NotFound() : Ok(res);
        }
    }
}
