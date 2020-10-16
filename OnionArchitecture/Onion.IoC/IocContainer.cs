using Microsoft.Extensions.DependencyInjection;
using Onion.Repository;
using Onion.Repository.Context;
using Onion.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace Onion.IoC
{
    public static class IocContainer
    {
        public static void ConfigureIoC(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IAppUserService, AppUserService>(); ;
            services.AddDbContext<ApplicationDbContext>();
        }
    }
}
