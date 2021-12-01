using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyBlog.Domain.Repositories;
using MyBlog.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Infrastructure.Extensions
{
    public static class InfrastructureExtension
    {
        public static void AddInfrastructureExtensions(this IServiceCollection services, IConfiguration Configuration)
        {
            var ConString = Configuration.GetConnectionString("npgsql");
            services.AddScoped<IArticleRepository>(x => new ArticleRepository(ConString));
            services.AddScoped<IUserRepository>(x => new UserRepository(ConString));
            services.AddScoped<IOptionRepository, OptionRepository>();
        }
    }
}
