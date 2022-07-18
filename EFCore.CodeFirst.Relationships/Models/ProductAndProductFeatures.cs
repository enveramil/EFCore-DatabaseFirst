using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.CodeFirst.Relationships.Models
{
    public class ProductAndProductFeatures
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public string CategoryName { get; set; }

        public int Width { get; set; }

        public int Height { get; set; }

    }
}
