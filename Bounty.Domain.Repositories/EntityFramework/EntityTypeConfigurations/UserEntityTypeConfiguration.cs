using Bounty.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bounty.Domain.Repositories.EntityFramework.EntityTypeConfigurations
{
    public class UserEntityTypeConfiguration : EntityTypeConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(m => m.ID);
            builder.Property(m => m.RowVersion)
                .IsRowVersion()
                .IsRequired();
        }
    }
}
