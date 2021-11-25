using MediatR;
using Microsoft.Extensions.DependencyInjection;
using MyBlog.Application.Services;
using MyBlog.Domain.CommandHandlers;
using MyBlog.Domain.EventHandlers;
using MyBlog.Domain.QueryHandlers.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Application.Extensions
{
    public static class ApplicationExtension
    {
        public static void AddApplicationExtensions(this IServiceCollection services)
        {
            services.ConfigureAutoMapper();


            services.AddScoped<IArticleService,ArticleManager>();
            services.AddScoped<IUserService, UserManager>();
        }

    }
}
