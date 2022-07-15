﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.CodeFirst.Relationships.DAL
{
    public class ProductFull
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public int Height { get; set; }

    }
}
