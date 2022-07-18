

using Microsoft.EntityFrameworkCore;
using StoreProcedured;
using StoreProcedured.DataAccessLayer;

DbContextInitializer.Build();

using (var _context = new AppDbContext())
{
    //var category = new Category() { Name = "Telefonlar" };

    //var category = _context.Categories.First(x=>x.Id == 1);




    //category.Products.Add(new()
    //{
    //    Name = "Iphone13promax",
    //    ProductCode = "HBCV00000ODIX7",
    //    Price = 34000,
    //    Stock = 3,
    //});

    //_context.Add(category);
    //_context.SaveChanges(); 

    //var category = new Category() { Name = "Arabalar"};
    //var category = _context.Categories.First(x=>x.Id == 2);
    //category.Products.Add(new()
    //{
    //    Name = "BMW",
    //    ProductCode = "BMWCODEXB2022",
    //    Price = 1450000,
    //    Stock = 3,
    //    ProductFeature = new()
    //    {
    //        Color = "Black",
    //        ScreenSize = 10.5m,
    //        BateryCapacity = 350
    //    }

    //});

    //_context.Add(category);
    //_context.SaveChanges();


    //var getProducts = _context.Products.FromSqlRaw("exec sp_get_products").ToList();


    // Eager Loading
    //var products = _context.Categories.Include(p=> p.Products).ThenInclude(pf=>pf.ProductFeature)
    //    .ToList();

    // Get Data with Navigation Property

    //var category = _context.Categories.First();
    //var products = _context.Products.First();

    //_context.Entry(category).Collection(x => x.Products).Load();
    //_context.Entry(products).Reference(x => x.ProductFeature).Load();


    //var category2 = await _context.Categories.FirstAsync();


    //var getFullData = _context.ProductFulls.FromSqlRaw("exec sp_get_products_full").ToList();


    int categoryId = 1;
    decimal price = 80;

    var getFullData = _context.ProductFulls.FromSqlInterpolated($"exec sp_get_products_full_parameters {categoryId},{price}").ToList();


    Console.WriteLine("finito");

}