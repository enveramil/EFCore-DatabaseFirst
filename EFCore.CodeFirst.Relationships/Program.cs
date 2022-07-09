using EFCore.CodeFirst.Relationships;
using EFCore.CodeFirst.Relationships.DAL;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();

using (var dbContext = new AppDbContext())
{

    //var brand = new Category() { Name = "Volkswagen", CarModel = new List<Product>()
    //{
    //    new Product() { Name = "Golf", Price = 500000, Stock = 22, Barcode = 20220907},
    //    new Product() { Name = "Polo", Price = 400000, Stock = 12, Barcode = 20220907}
    //}
    //};

    //var brand2 = new Category()
    //{
    //    Name = "Renault",
    //    CarModel = new List<Product>()
    //{
    //    new Product() { Name = "Clio", Price = 500000, Stock = 22, Barcode = 20220907},
    //    new Product() { Name = "Zoe", Price = 400000, Stock = 12, Barcode = 20220907}
    //}
    //};

    //dbContext.Add(brand);
    //dbContext.Add(brand2);
    //dbContext.SaveChanges();

    dbContext.CarModel.Add(new() { 
        Name = "Airpods Pro", Price = 5000, Stock = 3, Barcode = 20220103, Kdv = 1.18m
    });

    dbContext.SaveChanges();





}
