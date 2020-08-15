using Bounty.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bounty.Domain.Repositories.EntityFramework.EntityTypeConfigurations
{
    public class PlatformEntityTypeConfiguration : EntityTypeConfiguration<OpenPlatform>
    {
        public override void Configure(EntityTypeBuilder<OpenPlatform> builder)
        {
            builder.Property(m => m.OpenID)
                .HasMaxLength(50)
                .IsRequired();
        }
    }
}
