using MediatR;
using Microsoft.Extensions.DependencyInjection;
using MyBlog.Domain.CommandDispatchers;
using MyBlog.Domain.CommandHandlers;
using MyBlog.Domain.EventDispatchers;
using MyBlog.Domain.EventHandlers;
using MyBlog.Domain.QueryHandlers.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Domain.Extensions
{
    public static class DomainExtension
    {
        public static void AddDomainExtensions(this IServiceCollection services)
        {
            services.AddMediatR(typeof(ArticleCommandHandler), typeof(ArticleCreatedEventHandler), typeof(ArticleQueryHandler));


            services.AddScoped<ICommandQueryDispatcher,CommandQueryDispatcher>();
            services.AddScoped<IEventDispatcher,EventDispatcher>();
        }
    }
}
