using Bounty.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
                                        
namespace Bounty.Domain.Repositories.EntityFramework.EntityTypeConfigurations
{
    public abstract class EntityTypeConfiguration<TAggregateRoot>
        : ITypeConfiguration, IEntityTypeConfiguration<TAggregateRoot> where TAggregateRoot : class, IAggregateRoot
    {
        public abstract void Configure(EntityTypeBuilder<TAggregateRoot> builder);

        public void Configure(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(this);
        }
    }
}
