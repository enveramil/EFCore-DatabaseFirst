﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

        public decimal Kdv { get; set; }

        public int Stock { get; set; }

        public int Barcode { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public decimal PriceKdv { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Computed)] // update sorgularında dahil etmez.
        //public DateTime? CreatedDate { get; set; } = DateTime.Now;

        // Foreign Key
        //public int? CategoryId { get; set; }
        //public Category? CarBrands { get; set; }

        //public ProductFeature ProductFeature { get; set; }

        // Identity : update sorguları dahil etmez.
        // Computed : update ve add dahil etmez.

    }
}
