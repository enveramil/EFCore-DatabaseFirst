using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.CodeFirst.DAL
{
    // Bu sınıf veritabanımıza karşılık gelmektedir.
    public class AppDbContext  : DbContext  
    {
        // DbSet'e verilen isim veritabanındaki tablomuza karşılık gelmektedir.
        public DbSet<Product> Products { get; set; }

        // Veritabanı yolunu belirleyeceğiz
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // veritabanı yolunu appsettings.json dan okuyacağız.
            DbContextInitializer.Build();
            optionsBuilder.UseSqlServer(DbContextInitializer.Configuration.GetConnectionString("SqlCon"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // IsFixedLength() : Min ve Max karakterleri eşit sınırlar.
            // HasKey() : Primary key olarak değerleri işaretler.
            // nchar : Veri tipi veritabanında sabit uzunlukta olmasını belirtmektedir. İçerisindeki n unique olmasını sağlar.



            //modelBuilder.Entity<Product>().ToTable("ProductTB","productsTb");
            modelBuilder.Entity<Product>().HasKey(x => x.Product_Id);
            modelBuilder.Entity<Product>().Property(x => x.Name).IsRequired().HasMaxLength(50).IsFixedLength();
            base.OnModelCreating(modelBuilder);
        }

        //public override int SaveChanges()
        //{
        //    ChangeTracker.Entries().ToList().ForEach(e =>
        //    {
        //        // e - memory de track edilen her bir dataya karşılık gelmektedir.
        //        if (e.Entity is Product product)
        //        {
        //            if (e.State == EntityState.Added)
        //            {
        //                product.CreatedDate = DateTime.Now;
        //            }
        //        }
        //    });
        //    return base.SaveChanges();
        //}
    }
}
