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

    //dbContext.CarModel.Add(new() { 
    //    Name = "Airpods Pro", Price = 5000, Stock = 3, Barcode = 20220103, Kdv = 1.18m
    //});

    //dbContext.SaveChanges();

    //var category = new Category() { Name = "Kalemler" };
    //category.Products.Add(new() { Name="Kalem1", Price=10, Stock = 10, Barcode = 20220403,
    //    ProductFeature = new()
    //    {
    //        Color = "red", Height=100, Width=100
    //    },
    //    });
    //category.Products.Add(new()
    //{
    //    Name = "Kalem2",
    //    Price = 10,
    //    Stock = 10,
    //    Barcode = 20220403,
    //    ProductFeature = new()
    //    {
    //        Color = "yellow",
    //        Height = 100,
    //        Width = 100
    //    },

    //});
    //category.Products.Add(new()
    //{
    //    Name = "Kalem3",
    //    Price = 10,
    //    Stock = 10,
    //    Barcode = 20220403,
    //    ProductFeature = new()
    //    {
    //        Color = "blue",
    //        Height = 100,
    //        Width = 100
    //    },

    //});

    //dbContext.Categories.Add(category);


    // Eager Loading
    // Kategoriye bağlı ürünlerde veritabanından çekilmektedir.

    //var categoryWithProducts = dbContext.Categories.Include(x => x.Products).ThenInclude(x=>x.ProductFeature).First();

    //categoryWithProducts.Products.ForEach(product =>
    //{
    //    Console.WriteLine($"{categoryWithProducts.Name} {product.Name} {product.ProductFeature.Color}");
    //});

    var product = dbContext.Products.Include(x => x.ProductFeature).Include(x=>x.Category).ToList();

    product.ForEach(x =>
    {
        Console.WriteLine($"{x.Name} {x.ProductFeature.Color} {x.Category.Name}");
    });






}
