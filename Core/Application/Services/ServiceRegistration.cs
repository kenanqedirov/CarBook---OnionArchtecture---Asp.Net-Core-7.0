using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public static class ServiceRegistration
    {
        public static void AddApplicationServices(this IServiceCollection services ,
            IConfiguration configuration)
        {
            services.AddMediatR(config =>
            config.RegisterServicesFromAssembly(typeof(ServiceRegistration).Assembly));

        }
    }
}
