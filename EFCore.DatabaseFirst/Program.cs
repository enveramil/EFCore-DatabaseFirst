using EFCore.DatabaseFirst.DataAccessLayer;
using Microsoft.EntityFrameworkCore;

// Build metodunun bir kere çalıştırılıp veritabanın inşa edilmesi gerekmektedir.
DbContextInitializer.Build();


using (var _context = new AppDbContext(DbContextInitializer.OptionsBuilder.Options))
{
    // using kullanılmasının sebebi işlem sonucunda memory den dispose olunur.
    var products = await _context.Products.ToListAsync();

    // Tüm verileri foreach ile ekrana yazdıracağız.
    products.ForEach(p =>
    {
        Console.WriteLine($"{p.id}: {p.Name}: {p.Price}");
    });

}