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

    //var personList = dbContext.People.ToList();


    //var productFulls = dbContext.ProductFulls.FromSqlRaw(
    //    @"select p.Id, c.Name 'CategoryName', p.Name, p.Price, pf.Height from Products p 
    //    join ProductFeatures pf on p.Id = pf.Id
    //    join Categories c on c.Id = p.CategoryId"

    //    ).ToList();

    //Console.WriteLine("İşlem bitti...");


    //dbContext.Products.Where(x => x.Name == "Enver").Select(x => new { name = x.Name, price = x.Price,
    //    stock = x.Stock, barcode = x.Barcode 
    //});

    //dbContext.Products.Add(new Product { Name = "Kalemler", Price = 100, DiscountPrice = 80, Barcode = 123, Stock = 1234, url="abc" });

    //dbContext.SaveChanges();    


    //dbContext.People.Add(new People() { Name = "Enver", PhoneNumber = "05551535333" });
    //dbContext.People.Add(new People() { Name = "Kemal", PhoneNumber = "05362231414" });

    //dbContext.SaveChanges();

    //var getNumber = dbContext.People.ToList().Where(x => formatPhoneNumber(x.PhoneNumber) == "5551535333").ToList();

    //var formatData = dbContext.People.ToList().Select(x => new { name = x.Name, phoneNumber = formatPhoneNumber(x.PhoneNumber) }).ToList();

    //formatData.ForEach(x =>
    //{
    //    Console.WriteLine($"Name: {x.name}, Phone: {x.phoneNumber}");
    //});

    //Console.WriteLine("İşlem bitti...");


    //var addCategoryAndProducts = new Category() { Name = "kalemler" , };

    ////addCategoryAndProducts.Products.Add(new() { Name = "Kalem1", Price = 20, Stock = 3, Barcode = 1234, 
    ////    DiscountPrice = 10, url = "kalem.com" });

    //addCategoryAndProducts.Products.Add(new()
    //{
    //    Name = "Kalem53",
    //    Price = 53,
    //    Stock = 53,
    //    Barcode = 5353,
    //    DiscountPrice = 35,
    //    url = "kalem53.com",
    //    ProductFeature = new ProductFeature() { Color="red53", Height=53, Width=53},
    //    Category = addCategoryAndProducts
    //});

    //dbContext.Categories.Add(addCategoryAndProducts);

    //dbContext.Categories.Update(addCategoryAndProducts);



    //var category = dbContext.Categories.Where(x=>x.Id == 3).First(); 
    //var addProduct = new Product() { Name="Enver", Price=1, Stock=1, Barcode=1, url="ee", DiscountPrice=1,
    //     CategoryId = category.Id
    //};

    //dbContext.Add(addProduct);

    //dbContext.SaveChanges();



    #region Join

    //var result = (from c in dbContext.Categories
    //              join p in dbContext.Products on c.Id equals p.CategoryId
    //              select new
    //              {
    //                  CategoryName = c.Name,
    //                  ProductName = p.Name,
    //                  ProductPrice = p.Price,
    //              }).ToList();
    //Console.WriteLine("finish");


    //var onlyId = (from p in dbContext.Products
    //             where p.CategoryId == 3 select p).ToList();

    //Console.WriteLine("finish");


    //var result = dbContext.Categories
    //    .Join(dbContext.Products, c => c.Id, p => p.CategoryId, (c, p) => new { c, p })
    //    .Join(dbContext.ProductFeatures, x => x.p.Id, y => y.Id, (c, pf) => new
    //    {
    //        CategoryName = c.c.Name,
    //        ProductName = c.p.Name,
    //        ProductFeatureColor = pf.Color
    //    });


    //var result2 = (from c in dbContext.Categories
    //              join p in dbContext.Products on c.Id equals p.CategoryId
    //              join pf in dbContext.ProductFeatures on p.Id equals pf.Id
    //              select new { c, p, pf }).ToList();

    //result2.ForEach(x =>
    //{
    //    Console.WriteLine($"CategoryName: {x.c.Name}, ProductName: {x.p.Name}, ProductFeatureColor: {x.pf.Color}");
    //});



    //var leftJoinResult = await (from p in dbContext.Products
    //                    join pf in dbContext.ProductFeatures on p.Id equals pf.Id into pfList
    //                    from pf in pfList.DefaultIfEmpty()
    //                    select new { p }

    //              ).ToListAsync();


    //var rightJoinResult = await (from pf in dbContext.ProductFeatures
    //                            join p in dbContext.Products on pf.Id equals p.Id into pList
    //                            from p in pList.DefaultIfEmpty()
    //                            select new { p }

    //              ).ToListAsync();


    //var left = (from product in dbContext.Products
    //            join productFeature in dbContext.ProductFeatures on product.Id equals productFeature.Id into pfList
    //            from productFeature in pfList.DefaultIfEmpty()
    //            select new { 
    //                Id = product.Id,
    //                Name = product.Name,
    //                Color = productFeature.Color == null ? 5 : 0
    //            }).ToList();

    //var right = (from productFeature in dbContext.ProductFeatures
    //            join product in dbContext.Products on productFeature.Id equals product.Id into pfList
    //            from product in pfList.DefaultIfEmpty()
    //            select new
    //            {
    //                Id = product.Id,
    //                Name = product.Name,
    //                Color = productFeature.Color == null ? 5 : 0
    //            }).ToList();

    //// Union(): İki listeyi birleştirir.
    //var outerJoin = left.Union(right);

    //outerJoin.ToList().ForEach(x =>
    //{
    //    Console.WriteLine($"Id: {x.Id}, Name: {x.Name}, Color: {x.Color}");

    //}); 
    #endregion

    #region RawSqlAndFromSql
    //decimal price = 30;
    //var id = 3;

    //var products = await dbContext.Products.FromSqlRaw("select * from products").ToListAsync();


    //var product = await dbContext.Products.FromSqlRaw("select * from products where Id={0}",id).FirstAsync();

    //var getPrice = await dbContext.Products.FromSqlRaw("select * from products where Price>{0}",price).ToListAsync();

    //var getData = await dbContext.Products.FromSqlInterpolated($"select * from products where Price>{price}").ToListAsync();

    //var data = await dbContext.ProductEssentials.FromSqlRaw("select Name,Price from products").ToListAsync();

    //var productFeature = await dbContext.ProductWithFeatures.FromSqlRaw(@"select p.Id, p.Name, p.Price, pf.Color, pf.Height from Products p
    //inner join ProductFeatures pf on p.Id = pf.Id").ToListAsync();

    //productFeature.ForEach(x =>
    //{
    //    Console.WriteLine($"Name: {x.Name}, Price: {x.Price}, Color: {x.Color}, Height: {x.Height}");
    //});

    //Console.WriteLine("finish...");


    //var products = dbContext.ProductEssentials.Where(x=>x.Price>30).ToList();

    //var productAndProductsFeature = dbContext.ProductAndProductFeatures.Where(x=>x.Name=="Kalem53").ToList(); 
    #endregion


    #region Pagination
    // PAGINATION
    // Take(10) : İlk 10 veriyi al
    // Skip(2)  : 2 atla datayı al

    //GetProducts(1, 3, dbContext).ForEach(x =>
    //{
    //    Console.WriteLine($"{x.Name}, {x.Price}");
    //}); 
    #endregion



    //var category = new Category() { Name = "Telefonlar" };

    //category.Products.Add(new()
    //{
    //    Name = "Iphone11",
    //    Price = 16000,
    //    DiscountPrice = 15000,
    //    Stock = 24,
    //    Barcode = 19980505,
    //    url = "apple.com",
    //    ProductFeature = new ProductFeature()
    //    {
    //        Color = "Red",
    //        Width = 100,
    //        Height = 100

    //    }

    //});

    //dbContext.Categories.Add(category);
    //dbContext.SaveChanges();


    // IgnoreQueryFilters() : Global Query iptal işlemi gerçekleştirilir.

    //var products = dbContext.Products.ToList();

    //var productsWithFeature = dbContext.Products.TagWith("Product ve ProductFeature Tabloları")
    //    .Include(x => x.ProductFeature).Where(y => y.Price > 30).ToList();


    var product = dbContext.Products.First(x=>x.Id==8);

    product.Price = 17500;

    // DB de değişiklik olduğunu state ile belirtebiliriz.
    //dbContext.Entry(product).State = EntityState.Modified;

    dbContext.Update(product);

    dbContext.SaveChanges();    

    Console.WriteLine("point");

}



//string formatPhoneNumber(string phone)
//{
//    return phone.Substring(1, phone.Length - 1);
//}

//static List<Product> GetProducts(int page, int pageSize, AppDbContext dbContext)
//{
//    return dbContext.Products.OrderByDescending(x => x.Id).Skip((page - 1) * pageSize).Take(pageSize).ToList();
//}
