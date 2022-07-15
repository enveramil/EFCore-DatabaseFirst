using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.CodeFirst.Relationships.DAL
{
    [Index(nameof(Name))]
    [Index(nameof(Price))]
    [Index(nameof(Name),nameof(Price))]
    public class Product
    {

        public int Id { get; set; }

        public string url { get; set; }

        public string Name { get; set; }

        [Precision(9,2)]
        public decimal Price { get; set; }

        [Precision(9,2)]
        public decimal DiscountPrice { get; set; }

        public int Stock { get; set; }

        public int Barcode { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)] // update sorgularında dahil etmez.
        //public DateTime? CreatedDate { get; set; } = DateTime.Now;

        // Foreign Key
        public int CategoryId { get; set; }
        public  Category Category { get; set; }

        public  ProductFeature ProductFeature { get; set; }

        // Identity : update sorguları dahil etmez.
        // Computed : update ve add dahil etmez.

    }
}
