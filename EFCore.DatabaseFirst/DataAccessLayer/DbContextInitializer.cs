using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.DatabaseFirst.DataAccessLayer
{

    // optionsları tutmak için oluşturulan sınıftır.
    // Veritabanı yoluna erişmemiz lazım.
    // Uygulamanın her yerinden erişmek için static yapıyoruz.
    


    public class DbContextInitializer
    {
        // Veritabanı ile ilgili ayarları bu sınıfta gerçekleştireceğiz.

        // IConfigurationRoot, appsettings.json dosyasını okumak için kullanılmaktadır.
        public static IConfigurationRoot Configuration;

        // Veritabanı ile ilgili optionları belirteceğim yerdir.
        public static DbContextOptionsBuilder<AppDbContext> OptionsBuilder;

        public static void Build()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();
            OptionsBuilder = new DbContextOptionsBuilder<AppDbContext>();

            // appsettings.json sınıfındaki veriyi okumak için kopyalama işlemine onay vermemiz gerekmektedir.
            OptionsBuilder.UseSqlServer(Configuration.GetConnectionString("SqlCon"));
        }
    }
}
