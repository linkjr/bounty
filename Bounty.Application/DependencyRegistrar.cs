using Bounty.IApplication;
using Bounty.Infrastructure.Web;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bounty.Application
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public IServiceCollection Register(IServiceCollection services)
        {
            services.AddScoped<IUserService, UserService>();

            return services;
        }
    }
}
