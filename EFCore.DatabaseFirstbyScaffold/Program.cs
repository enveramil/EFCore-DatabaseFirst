// See https://aka.ms/new-console-template for more information
using EFCore.DatabaseFirstbyScaffold.Models;
using Microsoft.EntityFrameworkCore;

Console.WriteLine("Hello, World!");

using (var _context = new EFCoreDatabaseFirstContext())
{
    // using kullanılmasının sebebi işlem sonucunda memory den dispose olunur.
    var products = await _context.Products.ToListAsync();

    // Tüm verileri foreach ile ekrana yazdıracağız.
    products.ForEach(p =>
    {
        Console.WriteLine($"{p.Id}: {p.Name}: {p.Price}: {p.Stock}");
    });
}