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

    //var product = dbContext.Products.Include(x => x.ProductFeature).Include(x=>x.Category).ToList();

    //product.ForEach(x =>
    //{
    //    Console.WriteLine($"{x.Name} {x.ProductFeature.Color} {x.Category.Name}");
    //});


    //var products = dbContext.Products.First();
    //var category = dbContext.Categories.First();   

    //if (true)
    //{
    //    // Navigation Propertyler üzerinden dataları çekmek daha verimlidir. 

    //    dbContext.Entry(category).Collection(x => x.Products).Load();
    //    dbContext.Entry(products).Reference(x => x.ProductFeature).Load();
    //}


    //var category = await dbContext.Categories.FirstAsync();
    //Console.WriteLine("Category verileri çekildi.");


    //var products = category.Products;

    //Console.WriteLine("Products verileri çekildi.");

    //var prodcuct = await dbContext.Products.FirstAsync();

    //var productFeature = prodcuct.ProductFeature;


    //var manager = dbContext.Person.Add(new Manager() { FirstName = "Özer", LastName = "Karagöl", Age = 45, Degree = 1 });

    //var employee = dbContext.Person.Add(new Employee() { FirstName = "Birsen", LastName = "Karagöl", Age = 40, Salary = 40000 });


    //var manager = dbContext.Managers.ToList();

    //var employee = dbContext.Employees.ToList();

    //var persons = dbContext.Person.ToList();

    //persons.ForEach(p =>
    //{
    //    switch (p)
    //    {
    //        case Manager manager:
    //            Console.WriteLine($"{manager.Degree}");
    //            break;
    //        case Employee employee:
    //            Console.WriteLine($"{employee.Salary}");
    //            break;
    //        default:
    //            break;
    //    }
    //});


    //dbContext.Person.Add(new Manager() { FirstName = "Ahsen", LastName="Amil", Age=24,Degree=9});

    //dbContext.Person.Add(new Employee() { FirstName = "Elif Beren", LastName = "Amil", Age = 24, Salary=3000 });

    //dbContext.Managers.Add(new Manager() { FirstName = "Enver", LastName = "Amil", Age = 23, Degree = 10 });
    //dbContext.Employees.Add(new Employee() { FirstName = "Ahmet", LastName = "Amil", Age = 23, Salary = 5000 });

    //dbContext.SaveChanges();


    //var category = new Category() { Name = "Arabalar" };

    //category.Products.Add(new()
    //{
    //    Name = "BMW", Stock = 1, Price = 500000, Barcode = 20220714, ProductFeature = new ProductFeature()
    //    {
    //        Color = "Black", Height=100, Width=100
    //    }
    //});

    //category.Products.Add(new()
    //{
    //    Name = "Mercedes",
    //    Stock = 1,
    //    Price = 300000,
    //    Barcode = 20220714,
    //    ProductFeature = new ProductFeature()
    //    {
    //        Color = "Red",
    //        Height = 100,
    //        Width = 100
    //    }
    //});

    //dbContext.Categories.Add(category);
    //dbContext.SaveChanges();

    var personList = dbContext.People.ToList();


    var productFulls = dbContext.ProductFulls.FromSqlRaw(
        @"select p.Id, c.Name 'CategoryName', p.Name, p.Price, pf.Height from Products p 
        join ProductFeatures pf on p.Id = pf.Id
        join Categories c on c.Id = p.CategoryId"

        ).ToList();

    Console.WriteLine("İşlem bitti...");










}
