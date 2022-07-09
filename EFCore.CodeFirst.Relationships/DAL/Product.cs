using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.CodeFirst.Relationships.DAL
{
    public class Product
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Stock { get; set; }

        public int Barcode { get; set; }

        // Foreign Key
        public int? CategoryId { get; set; }
        public Category? CarBrands { get; set; }

        //public ProductFeature ProductFeature { get; set; }

    }
}
