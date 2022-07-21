﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProcedured.DataAccessLayer
{
    public class ProductFeature
    {
        [ForeignKey("Product")]
        public int Id { get; set; }

        public string Color { get; set; }

        public decimal? ScreenSize { get; set; }

        public int BateryCapacity { get; set; }

        public Product Product { get; set; }

    }
}
