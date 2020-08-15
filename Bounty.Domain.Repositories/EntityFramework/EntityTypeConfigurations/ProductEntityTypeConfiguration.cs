using Bounty.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bounty.Domain.Repositories.EntityFramework.EntityTypeConfigurations
{
    public class ProductEntityTypeConfiguration : EntityTypeConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(m => m.Price)
                .HasColumnType("decimal(6,2)");
        }
    }
}
