using Concurrency.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Concurrency.Web.Controllers
{
    public class ProductsController : Controller
    {
        // Created instance variable from DbContext
        private readonly AppDbContext _context;

        // Created constructor for Initializer DbContext
        public ProductsController(AppDbContext context)
        {
            _context = context;
        }
        
        // Created function named of List it works all products 
        public async Task<IActionResult> List()
        {


            return View(await _context.Products.ToListAsync());
        }

        // Created function named of Update.
        // Function takes one parameters named of 'id'
        // The data is updated according to id inside function.
        public async Task<IActionResult> Update(int id)
        {
            var products = await _context.Products.FindAsync(id);

            return View(products);
        }

        // product objects reflected in the database.
        [HttpPost]
        public async Task<IActionResult> Update(Product product)
        {
            try
            {
                _context.Products.Update(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(List));
            }
            catch (DbUpdateConcurrencyException exception)
            {
                // take the all data inside db.

                var takeException = exception.Entries.First();

                // get current values.
                var currentProducts = takeException.Entity as Product;

                // get database values.
                var databaseValues = takeException.GetDatabaseValues();

                

                // get client values 
                var clientValues = takeException.CurrentValues;

                if (databaseValues == null)
                {
                    ModelState.AddModelError(string.Empty, "Data deleted from another user...");
                    ViewBag.Message = "Hey there ";
                }
                else
                {
                    // database values
                    var databaseProduct = databaseValues.ToObject() as Product;
                    ModelState.AddModelError(string.Empty, "Data updated from another user...");
                    ModelState.AddModelError(string.Empty, $"Name:{databaseProduct.Name}, Price:{databaseProduct.Price}, Stock:{databaseProduct.Stock}");
                }
            }
            return View(product);
        }

    }
}
