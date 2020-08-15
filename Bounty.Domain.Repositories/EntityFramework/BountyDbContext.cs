using Bounty.Domain.Repositories.EntityFramework.EntityTypeConfigurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Bounty.Domain.Repositories.EntityFramework
{
    public class BountyDbContext : DbContext
    {
        public BountyDbContext(DbContextOptions<BountyDbContext> options)
            : base(options)
        {
            //base.Database.EnsureDeleted();
            //base.Database.EnsureCreated();
            this.Database.Migrate();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var configurationTypes = from m in Assembly.GetExecutingAssembly().GetTypes()
                                     where (m.BaseType?.IsGenericType ?? false)
                                     && m.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>)
                                     select m;
            foreach (var type in configurationTypes)
            {
                var typeConfiguration = Activator.CreateInstance(type) as ITypeConfiguration;
                typeConfiguration.Configure(modelBuilder);
            }

            base.OnModelCreating(modelBuilder);
        }
    }
}
