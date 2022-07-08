using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.CodeFirst.DAL
{
    [Table("ProductsDBB",Schema ="productssDbb")]
    public class Product
    {
        // Migration yapılınca EFCore otomatik olarak tanımlamaları yapmaktadır.
        // Entity isimlendirmeleri önem arz etmektedir. Otomatik olarak id primary key olarak belirlenmektedir.
        // Herhangi bir entity sınıfının id si olmadığı zaman manuel olarak belirtmemiz gerekmektedir.
        //[Column(Order = 1)]
        public int Product_Id { get; set; }

        // [] içerisinde yazılanların validation da karşılığı bulunmaktadır.
        //[Column("name2",Order = 3)]
        //[MaxLength(50)]
        //[StringLength(100,MinimumLength =10)]
        public string Name { get; set; }

        //[Column("price2",Order =2,TypeName ="decimal(18,2)")]
        public decimal Price { get; set; }

        
        public int Stock { get; set; }

        public int Barcode { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
}
