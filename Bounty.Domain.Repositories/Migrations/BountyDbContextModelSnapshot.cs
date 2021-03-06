﻿// <auto-generated />
using System;
using Bounty.Domain.Repositories.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bounty.Domain.Repositories.Migrations
{
    [DbContext(typeof(BountyDbContext))]
    partial class BountyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bounty.Domain.Models.OpenPlatform", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Disabled");

                    b.Property<string>("OpenID")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Platform");

                    b.Property<byte[]>("RowVersion");

                    b.Property<Guid>("UserID");

                    b.HasKey("ID");

                    b.ToTable("OpenPlatform");
                });

            modelBuilder.Entity("Bounty.Domain.Models.Product", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Deadline");

                    b.Property<bool>("Disabled");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(6,2)");

                    b.Property<byte[]>("RowVersion");

                    b.Property<int>("Sotcks");

                    b.Property<Guid>("UserID");

                    b.HasKey("ID");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("Bounty.Domain.Models.User", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Disabled");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("ID");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
