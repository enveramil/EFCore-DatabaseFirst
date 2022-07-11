﻿// <auto-generated />
using EFCore.CodeFirst.Relationships.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EFCore.CodeFirst.Relationships.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220711142111_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EFCore.CodeFirst.Relationships.DAL.BasePerson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Person");

                    b.HasDiscriminator<string>("Discriminator").HasValue("BasePerson");
                });

            modelBuilder.Entity("EFCore.CodeFirst.Relationships.DAL.Employee", b =>
                {
                    b.HasBaseType("EFCore.CodeFirst.Relationships.DAL.BasePerson");

                    b.Property<decimal>("Salary")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasDiscriminator().HasValue("Employee");
                });

            modelBuilder.Entity("EFCore.CodeFirst.Relationships.DAL.Manager", b =>
                {
                    b.HasBaseType("EFCore.CodeFirst.Relationships.DAL.BasePerson");

                    b.Property<int>("Degree")
                        .HasColumnType("int");

                    b.HasDiscriminator().HasValue("Manager");
                });
#pragma warning restore 612, 618
        }
    }
}