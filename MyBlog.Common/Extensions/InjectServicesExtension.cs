using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyBlog.Application.Extensions;
using MyBlog.Domain.Extensions;
using MyBlog.Infrastructure.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Common.Extensions
{
    public static class InjectServicesExtension
    {
        public static void AddServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplicationExtensions();
            services.AddInfrastructureExtensions(configuration);
            services.AddDomainExtensions();
        }
    }
}
