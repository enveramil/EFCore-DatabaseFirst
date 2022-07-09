using FluentAssertions.Common;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.CodeFirst.Relationships.DAL
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> CarModel { get; set; }

        //public DbSet<Category> CarBrands { get; set; }

        //public DbSet<ProductFeature> ProductFeatures { get; set; }

        //public DbSet<Student> Students { get; set; }

        //public DbSet<Teacher> Teachers { get; set; }

        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DbContextInitializer.Build();
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-DB9C9K6\\SQLEXPRESS;Initial Catalog=CodeFirstRelationships;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API ile ilişkileri tanımlama

            //modelBuilder.Entity<Category>().HasMany(x => x.Products).WithOne(x => x.Category).HasForeignKey(x => x.Category_Id);

            //modelBuilder.Entity<Product>().HasOne(x => x.ProductFeature).WithOne(x => x.Product).HasForeignKey<ProductFeature>(x => x.Id);


            //modelBuilder.Entity<Student>().HasMany(x => x.Teachers).WithMany(x => x.Students)
            //    .UsingEntity<Dictionary<string, object>>(
            //        "StudentTeacherManyToMany",
            //        x => x.HasOne<Teacher>().WithMany().HasForeignKey("Teacher_Id").HasConstraintName("FK_TeacherId"),
            //        x => x.HasOne<Student>().WithMany().HasForeignKey("Student_Id").HasConstraintName("FK_StudentId")
            //        );


            //modelBuilder.Entity<Category>().HasMany(x => x.CarModel).WithOne(x => x.CarBrands).HasForeignKey(x => x.CategoryId)
            //    .OnDelete(DeleteBehavior.SetNull); 


            modelBuilder.Entity<Product>().Property(x => x.PriceKdv).HasComputedColumnSql("[Price]/[Kdv]");

            base.OnModelCreating(modelBuilder);
        }

    }
}
