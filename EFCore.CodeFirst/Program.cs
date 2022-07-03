using EFCore.CodeFirst;
using EFCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

// Build metodu çağırılarak Configurationlar ayağa kaldırılır.
// appsettings.json dosyasını okunabilecek hale getirmektedir.
// api ve web projelerinde Configuration sınıfları hazır olarak gelmektedir.
DbContextInitializer.Build();
using (var _context = new AppDbContext())
{
    // Track edilmeyen datalar da Update() kullanılır.
    var product = new Product() { Id=3,Name="Seat LEon FR", Price=900000,Stock=1,Barcode=20190816};
    _context.Update(product);

    //var products = await _context.Products.FirstAsync();
    //Console.WriteLine(products.Name);
    //Console.WriteLine($"İlk state: {_context.Entry(products).State = EntityState.Detached}"); // unchanged
    //Console.WriteLine($"İkinci state: {_context.Entry(products).State}"); // modified
    //_context.Remove(products);
    //products.Stock = 10;
    //products.Name = "abcd";

    await _context.SaveChangesAsync();
    //Console.WriteLine($"Son state: {_context.Entry(products).State}"); // unchanged






    //var newProduct = new Product() {Name = "Leon fr", Price = 800000, Stock = 5, Barcode = 555555 };

    //Console.WriteLine($"ilk state : {_context.Entry(newProduct).State}");
    //_context.Entry(newProduct).State = EntityState.Added;
    ////await _context.AddAsync(newProduct);
    //Console.WriteLine(_context.Entry(newProduct).State);

    //await _context.SaveChangesAsync();


    // using kullanılmasının sebebi işlem sonucunda memory den dispose olunur.
    // AsNoTracking(), memory de tutulmaz. Track edilmez.
    //var products = await _context.Products.ToListAsync();

    //// Tüm verileri foreach ile ekrana yazdıracağız.
    //products.ForEach(p =>
    //{
    //    var state = _context.Entry(p).State;
    //    //p.Stock += 100;
    //    Console.WriteLine($"{p.Id}: {p.Name}: {p.Price}: {p.Stock} : state: {state}");
    //});

    //_context.SaveChanges();
}

