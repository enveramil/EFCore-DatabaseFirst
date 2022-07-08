﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.CodeFirst.Relationships.DAL
{
    public class ProductFeature
    {
        // one-to-one ilişkide child


        public int Id { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

        public string Color { get; set; }

        // navigation property
        //public Product Product { get; set; }

    }
}