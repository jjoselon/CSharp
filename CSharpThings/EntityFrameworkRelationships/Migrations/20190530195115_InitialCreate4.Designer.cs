﻿// <auto-generated />
using System;
using EntityFrameworkRelationships;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EntityFrameworkRelationships.Migrations
{
    [DbContext(typeof(DerivedContext))]
    [Migration("20190530195115_InitialCreate4")]
    partial class InitialCreate4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EntityFrameworkRelationships.Entities.Binnacle", b =>
                {
                    b.Property<int>("BinnacleId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title");

                    b.HasKey("BinnacleId");

                    b.ToTable("Binnacles");
                });

            modelBuilder.Entity("EntityFrameworkRelationships.Entities.Tag", b =>
                {
                    b.Property<int>("TagId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("BinnacleId");

                    b.Property<string>("Name");

                    b.HasKey("TagId");

                    b.HasIndex("BinnacleId");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("EntityFrameworkRelationships.Entities.Tag", b =>
                {
                    b.HasOne("EntityFrameworkRelationships.Entities.Binnacle")
                        .WithMany("Tags")
                        .HasForeignKey("BinnacleId");
                });
#pragma warning restore 612, 618
        }
    }
}
