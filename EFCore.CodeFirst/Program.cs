using EFCore.CodeFirst;
using EFCore.CodeFirst.DAL;
using Microsoft.EntityFrameworkCore;

// Build metodu çağırılarak Configurationlar ayağa kaldırılır.
// appsettings.json dosyasını okunabilecek hale getirmektedir.
// api ve web projelerinde Configuration sınıfları hazır olarak gelmektedir.
DbContextInitializer.Build();
using (var _context = new AppDbContext())
{
    // using kullanılmasının sebebi işlem sonucunda memory den dispose olunur.
    var products = await _context.Products.ToListAsync();

    // Tüm verileri foreach ile ekrana yazdıracağız.
    products.ForEach(p =>
    {
        Console.WriteLine($"{p.Id}: {p.Name}: {p.Price}: {p.Stock}");
    });

}

