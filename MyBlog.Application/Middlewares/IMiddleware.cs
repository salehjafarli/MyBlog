using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Application.Middlewares
{
    public interface IMiddleware
    {
        public Task InvokeAsync(HttpContext context);
    }

}
