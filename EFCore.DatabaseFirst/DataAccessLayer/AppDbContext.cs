using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.DatabaseFirst.DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        private DbContextOptionsBuilder<AppDbContext> OptionsBuilder;

        // Products tablosunu DbSet olarak belirtmek gerekmektedir.
        // Veritabanındaki tablo ismi ile fonksiyon ismi aynı olursa EFCore otomatik olarak ilişki kurmaktadır.
        // Product isminde generic sınıf DbSet içerisinde tutulmaktadır.
        // Aynı context üzerinden farklı db lere bağlantı sağlanabilir.
        public DbSet<Product> Products { get; set; }

        public AppDbContext()
        {

        }
        //ctor
        // Veritabanı ayarlarını DbContextOptions sınıfı üzerinden yapacağız.
        public AppDbContext(DbContextOptions<AppDbContext> options)  : base(options)
        {

        }

        public AppDbContext(DbContextOptionsBuilder<AppDbContext> optionsBuilder)
        {
            this.OptionsBuilder = optionsBuilder;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(DbContextInitializer.Configuration.GetConnectionString("SqlCon"));
        }


        /* protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         {
             // SqlServer'a bağlantı için bu fonksiyonu yeniden yapılandıracağız.
             // Veritabanına bağlanmak için hazırız.
             // AppDbContext sınıfından her obje oluşturduğumuzda bu ezilen metod çalışacak.
             optionsBuilder.UseSqlServer("Data Source=DESKTOP-DB9C9K6\\SQLEXPRESS;Initial Catalog=EFCoreDatabaseFirst;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
         }
        */


    }
}
