

using AutoMapper.QueryableExtensions;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using StoreProcedured;
using StoreProcedured.DataAccessLayer;
using StoreProcedured.DTO;
using StoreProcedured.Mappers;

DbContextInitializer.Build();


//var connection = new SqlConnection(DbContextInitializer.Configuration.GetConnectionString("SqlCon"));


using (var _context = new AppDbContext())
{
    #region Store Procedure
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


    //int categoryId = 1;
    //decimal price = 80;

    //var getFullData = _context.ProductFulls.FromSqlInterpolated($"exec sp_get_products_full_parameters {categoryId},{price}").ToList();


    // Veritabanına veri ekleyeceğiz.

    //var addProduct = new Product()
    //{
    //    Name = "Omix x600",
    //     ProductCode = "OMIXX6002022264",
    //      Price = 5000,
    //       Stock = 1,
    //        CategoryId = 1

    //};

    //var newProductId = new SqlParameter("@newId", System.Data.SqlDbType.Int);
    //newProductId.Direction = System.Data.ParameterDirection.Output;

    //_context.Database.ExecuteSqlInterpolated($"exec sp_insert_product {addProduct.Name}, {addProduct.ProductCode},{addProduct.Price},{addProduct.Stock},{addProduct.CategoryId}, {newProductId} out");

    //var newIdForProduct = newProductId.Value;


    //Console.WriteLine("finito"); 
    #endregion


    // Function
    // Functionlarda output değerleri yoktur. Sadece input değerleri vardır.
    // Functionlarda geriye bir değer dönmek zorundadırlar.
    // Bir Function içerisinde store procedure kullanamayız.
    // Functionlarda try catch bloklarını kullanamayız.

    // TABLE VALUED FUNCTION

    //var resultFromFunctionTable = _context.ProductFulls.ToList();


    //int categoryId = 2;
    //var productWithFeatures = _context.ProductWithFeatures.FromSqlInterpolated($"select * from fc_product_full_2({categoryId})").ToList();

    //var productWithFeatures = _context.GetProductWithFeatures(1).ToList();

    // AppDbContext de tanımlanan fonksiyonu tek başına kullanamayız. EFCore'un linq metotları ile birlikte kullanabiliriz.
    //var getTotalProduct = _context.Categories.Select(x => new
    //{
    //    CategoryName = x.Name,
    //    TotalProductCount = _context.GetProductCount(x.Id)
    //}).ToList();


    //int categoryId = 1;

    //var getCount = _context.ProductCounts.FromSqlInterpolated($"select dbo.fc_get_product_count({categoryId}) as Count").First().Count;

    // projection bir yansıtma işlemidir.
    //var products = _context.Products.Include(x=>x.Category).ToList();

    // Anonymous Type

    // IQueryable dönen tiplerde sql e sorgu atmaz. ToList ile alırız.
    //var products = _context.Products.Include(x=>x.Category).Include(x=>x.ProductFeature).Select(x=>new
    //{
    //    CategoryName = x.Category.Name,
    //    ProductName = x.Name,
    //    ProductPrice = x.Price,
    //    ScreenSize = (int?)x.ProductFeature.ScreenSize,
    //    BateryCapacity = (int?)x.ProductFeature.BateryCapacity
    //}).ToList();


    //var categories = _context.Categories.Include(x => x.Products).ThenInclude(x => x.ProductFeature)
    //    .Select(x=>new
    //    {
    //        CategoryName = x.Name,
    //        Products = String.Join(",",x.Products.Select(x=>x.Name)),
    //        TotalPrice = x.Products.Sum(x=>x.Price)

    //    }).ToList();

    // DTO

    //var products = _context.Products.Select(x=> new ProductDto
    //{
    //    CategoryName = x.Category.Name,
    //    ProductName = x.Name,
    //    //ProductPrice = x.Price,
    //    //ScreenSize = (decimal?)x.ProductFeature.ScreenSize

    //}).ToList();

    //var categories = _context.Categories.Select(x => new
    //{
    //    TotalScreenSize = x.Products.Select(x=> x.ProductFeature.ScreenSize).Sum()
    //}).ToList();


    //var products = _context.Products.ToList();
    //var productDto = ObjectMapper.Mapper.Map<List<ProductDto>>(products);

    //var products = _context.Products.ProjectTo<ProductDto>(ObjectMapper.Mapper.ConfigurationProvider).ToList();
    //var updateProducts = _context.Products.First();
    //updateProducts.Name = "Samsung A33 5G";

    // Category eklerken veritabanına yansıtmak için savechanges kullanılır.
    // Category eklenip, product eklenme kısmında bir sıkıntı çıkarsa diye transcation kullanılır.

    //var addCategory = new Category() { Name = "Akıllı Saatler" };
    //_context.Categories.Add(addCategory);
    //var product = new Product()
    //{
    //    Name = "Apple Watch",
    //    Price = 7000,
    //    Stock = 2,
    //    ProductCode = "APPLEWATCHSERIES7",
    //    Category = addCategory
    //};

    //_context.Products.Add(product);
    //_context.SaveChanges();
    //IDbContextTransaction transaction = null;
    //using (transaction = _context.Database.BeginTransaction())
    //{
    //    var addCategory = new Category() { Name = "Akıllı Saatler" };
    //    _context.Categories.Add(addCategory);

    //    _context.SaveChanges();


    //    var product = new Product()
    //    {
    //        Name = "Apple Watch",
    //        Price = 7000,
    //        Stock = 2,
    //        ProductCode = "APPLEWATCHSERIES7",
    //        CategoryId = addCategory.Id
    //    };

    //    _context.Products.Add(product);


    //    _context.SaveChanges();

    //    using (var dbContext2 = new AppDbContext(connection))
    //    {
    //        // Üstteki using içerisindeki transaction'u kullanacağımızı belirttik.
    //        dbContext2.Database.UseTransaction(transaction.GetDbTransaction());
    //        var getFirstProducts = dbContext2.Products.First();
    //        getFirstProducts.Price = 7000;
    //        dbContext2.SaveChanges();



    //    }
    //    transaction.Commit();



    using (var transaction = _context.Database.BeginTransaction(System.Data.IsolationLevel.Snapshot))
    {

        //var addProducts = new Product()
        //{
        //    Name = "asd",
        //    Stock = 1,
        //    ProductCode = "adssa",
        //    Price = 123,
        //    CategoryId = 2
        //};
        ////_context.Products.Add(addProducts);

        //var products = _context.Products.First();
        //products.Price = 8000;
        //_context.SaveChanges();


        //var products = _context.Products.ToList();

        //var product = _context.Products.First();
        //product.Price = 1000;
        //_context.SaveChanges();

        var products = _context.Products.ToList();

        var products2 = _context.Products.ToList();



        transaction.Commit();

    }














    }




