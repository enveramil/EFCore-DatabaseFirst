using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.CodeFirst.DAL
{
    public class Product
    {
        // Migration yapılınca EFCore otomatik olarak tanımlamaları yapmaktadır.
        // Entity isimlendirmeleri önem arz etmektedir. Otomatik olarak id primary key olarak belirlenmektedir.
        // Herhangi bir entity sınıfının id si olmadığı zaman manuel olarak belirtmemiz gerekmektedir.

        public int Id { get; set; } 
        public string Name { get; set; }
        public int Price { get; set; }
        public int Stock { get; set; }
        public int Barcode { get; set; }

    }
}
