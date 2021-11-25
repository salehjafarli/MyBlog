using Microsoft.Extensions.DependencyInjection;
using MyBlog.Application.MapProfiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Application.Extensions
{
    public static class AddAutoMappperExtension
    {
        public static void ConfigureAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ArticleProfile));
        }
    }
}
