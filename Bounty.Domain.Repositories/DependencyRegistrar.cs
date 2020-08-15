using Bounty.Domain.Repositories.EntityFramework;
using Bounty.Infrastructure.Web;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bounty.Domain.Repositories
{
    public class DependencyRegistrar : IDependencyRegistrar
    {
        public IServiceCollection Register(IServiceCollection services)
        {
            //services.AddScoped<BountyDbContext>();
            //services.AddScoped<DbContextOptions<BountyDbContext>>();
            //services.AddScoped(q => new BountyDbContext(q.GetRequiredService<DbContextOptions<BountyDbContext>>()));
            services.AddScoped<IRepositoryContext, BountyRepositoryContext>()
                .AddScoped<IUserRepository, UserRepository>();

            return services;
        }
    }
}
