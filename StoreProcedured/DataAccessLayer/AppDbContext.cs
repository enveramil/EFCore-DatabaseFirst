using Microsoft.EntityFrameworkCore;
using StoreProcedured.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProcedured.DataAccessLayer
{
    public class AppDbContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductFeature> ProductFeatures { get; set; }

        public DbSet<ProductFull> ProductFulls { get; set; }


        public AppDbContext() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            DbContextInitializer.Build();
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-DB9C9K6\\SQLEXPRESS;Initial Catalog=StoreProcedured;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasOne(x => x.ProductFeature).WithOne(y => y.Product).HasForeignKey<ProductFeature>(x=>x.Id);

            // Insert, Update, Delete işlemleri yapılmayacağı için HasNoKey() kullanılır.
            modelBuilder.Entity<ProductFull>().HasNoKey();
            base.OnModelCreating(modelBuilder);
        }
    }
}
