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

        //public DbSet<People> People { get; set; }

        //public DbSet<Manager> Managers { get; set; }

        //public DbSet<Employee> Employees { get; set; }

        //public DbSet<Person> People { get; set; }

        //public DbSet<ProductFull> ProductFulls { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<ProductFeature> ProductFeatures { get; set; }

        //public DbSet<Student> Students { get; set; }

        //public DbSet<Teacher> Teachers { get; set; }

        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Trace, Debug, Information, Warning, Error, Criticial
            // .LogTo(Console.WriteLine,Microsoft.Extensions.Logging.LogLevel.Information).UseLazyLoadingProxies()

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


            //modelBuilder.Entity<Product>().Property(x => x.PriceKdv).HasComputedColumnSql("[Price]/[Kdv]");

            //modelBuilder.Entity<Product>().Property(x => x.PriceKdv).ValueGeneratedOnAddOrUpdate(); // computed
            //modelBuilder.Entity<Product>().Property(x => x.Id).ValueGeneratedNever(); //None
            //modelBuilder.Entity<Product>().Property(x => x.Id).ValueGeneratedOnAdd(); //identity  

            //modelBuilder.Entity<Product>().Property(x => x.Price).HasPrecision(18, 2);

            // TPT
            // ToTable() : Her bir entity'e karşılık birer tablo oluşturmaktadır.
            //modelBuilder.Entity<BasePerson>().ToTable("PersonTable");
            //modelBuilder.Entity<Manager>().ToTable("ManagerTable");
            //modelBuilder.Entity<Employee>().ToTable("EmployeeTable");


            // Owned Entity Types with Fluent API

            //modelBuilder.Entity<Manager>().OwnsOne(x => x.Person, p=>
            //{
            //    p.Property(x => x.FirstName).HasColumnName("FirstName");
            //    p.Property(x => x.LastName).HasColumnName("LastName");
            //    p.Property(x => x.Age).HasColumnName("Age");
            //});
            //modelBuilder.Entity<Employee>().OwnsOne(x => x.Person, p=>
            //{
            //    p.Property(x => x.FirstName).HasColumnName("FirstName");
            //    p.Property(x => x.LastName).HasColumnName("LastName");
            //    p.Property(x => x.Age).HasColumnName("Age");
            //});


            //modelBuilder.Entity<ProductFull>().HasNoKey();


            //modelBuilder.Entity<Product>().Ignore(product => product.Barcode);
            //modelBuilder.Entity<Product>().Property(product => product.Name).IsUnicode(false); // varchar
            //modelBuilder.Entity<Product>().Property(product => product.url).HasColumnType("nvarchar(200)").HasColumnName("ProductUrl");


            //modelBuilder.Entity<Product>().HasIndex(x => x.Name).IncludeProperties(x=>new {x.Price,x.Stock,x.Barcode});
            //modelBuilder.Entity<Product>().HasCheckConstraint("ProductCheckConstraint", "[Price]>[DiscountPrice]");

            //modelBuilder.Entity<Product>().HasIndex(x => new { x.Name, x.Price });
            base.OnModelCreating(modelBuilder);
        }

    }
}
