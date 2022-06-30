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
    }
}
