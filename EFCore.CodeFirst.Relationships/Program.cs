using EFCore.CodeFirst.Relationships;
using EFCore.CodeFirst.Relationships.DAL;
using Microsoft.EntityFrameworkCore;

DbContextInitializer.Build();

using (var dbContext = new AppDbContext())
{
    //var products = await dbContext.Products.ToListAsync();  

    //var category = new Category() { Name = "Kalemler" };
    //var products = new Product() { Name = "Kalem2", Price = 50, Stock = 10, Barcode = 1234, CreatedDate = DateTime.Now, Category = category };
    //dbContext.Products.Add(products);
    //dbContext.SaveChanges();


    //var category = new Category() { Name = "Defterler" };

    //category.Products.Add(new() { Name="defter1", Price=100, Stock=12, Barcode=123, CreatedDate=DateTime.Now});
    //dbContext.Add(category);
    //dbContext.SaveChanges();    



    // Product => Parent Entity
    // ProductFeature => Child Entity

    //var category = new Category() { Name = "Apple" };
    //var category = dbContext.Categories.First(x => x.Name == "Apple");
    //var products = new Product() { Name = "iphone13pro", Price = 33000, Stock = 5, Barcode = 4321, Category = category};

    //ProductFeature productFeature = new ProductFeature() { Color="blue",Width=500,Height=500, Product = products};

    //dbContext.ProductFeatures.Add(productFeature);

    //dbContext.Products.Add(products);
    //dbContext.Categories.Add(products);
    //dbContext.SaveChanges();


    //var students = new Student() { Name = "Enver", Age = 23 };
    //students.Teachers.Add(new() { Name = "Tamer Dağ"});
    //students.Teachers.Add(new() { Name = "Taner Arsan" });

    //var teachers = new Teacher() { Name = "Zeynep Betül Yılmaz" };
    //teachers.Students.Add(new() { Name = "Enver Amil", Age = 24 });
    //teachers.Students.Add(new() { Name = "Şeyma Betül Karaca", Age= 25 });

    //dbContext.Add(teachers);
    //dbContext.SaveChanges();

    //dbContext.Add(students);
    //dbContext.SaveChanges();


    //var getTeacher = dbContext.Teachers.First(x => x.Name == "Zeynep Betül Yılmaz");

    //getTeacher.Students.AddRange(new List<Student>()
    //{
    //    new Student() { Name = "Ecem Balcılar", Age = 26 },
    //    new Student() { Name = "Batuhan Yüceur", Age = 23}
    //});

    //dbContext.SaveChanges();


    //var category = new Category()
    //{
    //    Name = "Renault",
    //    Products = new List<Product>()
    //{
    //    new() { Name="Clio", Price=80000, Stock=16683, Barcode=20220709},
    //    new() { Name="Fluence", Price=100000, Stock=6910, Barcode=20220709},
    //    new() { Name="ZOE", Price=120000, Stock=34, Barcode=20220709}
    //}

    //};

    //dbContext.Add(category);

    //var getCategory = dbContext.Categories.First();

    //var products = dbContext.Products.Where(x => x.CategoryId == getCategory.Id).ToList();

    //dbContext.RemoveRange(products);
    //dbContext.Remove(getCategory);

    var getCategory = dbContext.CarBrands.First();
    dbContext.Remove(getCategory);

    dbContext.SaveChanges();




}
