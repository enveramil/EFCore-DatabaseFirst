using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using StoreProcedured.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProcedured.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        // 1.DbConnection Alınır.
        //private DbConnection _connection;


        //// 2.Connection constructor da geçilir.
        //public AppDbContext(DbConnection connection)
        //{
        //    _connection = connection;
        //}
        // 3. Default constructor. Dışarıdan instance verilmez.
        public AppDbContext()
        {

        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductFeature> ProductFeatures { get; set; }

        //public DbSet<ProductFull> ProductFulls { get; set; }

        //public DbSet<ProductCount> ProductCounts { get; set; }

        //public DbSet<ProductWithFeatures> ProductWithFeatures { get; set; }


        //public IQueryable<ProductWithFeatures> GetProductWithFeatures(int categoryId) => FromExpression(() => GetProductWithFeatures(categoryId));

        //public int GetProductCount(int categoryId)
        //{
        //    throw new Exception(); 
        //}

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Build metodu appsettings.json dosyasından connectionu okumaya yarıyor.


            // Dışarıdan instance verilmediği zaman if bloğu içerisine girer.
            //if(_connection == default(DbConnection))
            //{
            //    DbContextInitializer.Build();
            //    optionsBuilder.UseSqlServer(DbContextInitializer.Configuration.GetConnectionString("SqlCon"));
            //}
            //else
            //{
            //    // Dışarıdan instance verildiği için else bloğuna girer.
            //    optionsBuilder.UseSqlServer(_connection);
            //}

            DbContextInitializer.Build();
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-DB9C9K6\\SQLEXPRESS;Initial Catalog=StoreProcedured;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Product>().HasOne(x => x.ProductFeature).WithOne(y => y.Product).HasForeignKey<ProductFeature>(x=>x.Id);

            // Insert, Update, Delete işlemleri yapılmayacağı için HasNoKey() kullanılır.
            // ToFunction("Function Name") : Parametre almıyacak ve geriye table döndürecek.

            //modelBuilder.Entity<ProductFull>().ToFunction("fc_product_full");
            //modelBuilder.HasDbFunction(typeof(AppDbContext).GetMethod(nameof(GetProductWithFeatures), new[] {typeof(int)})!).HasName("fc_product_full_2");


            //modelBuilder.HasDbFunction(typeof(AppDbContext).GetMethod(nameof(GetProductCount), new[] { typeof(int) })!).HasName("fc_get_product_count");

            //modelBuilder.Entity<ProductCount>().HasNoKey();

            base.OnModelCreating(modelBuilder);
        }
    }
}
