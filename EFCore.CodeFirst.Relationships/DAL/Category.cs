using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.CodeFirst.Relationships.DAL
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        // null exception engellemek için initialize işlemi yapıldı.
        // public virtual işlemi lazy loading de kullanılır.
        public  List<Product> Products { get; set; } = new List<Product>();

        
    }
}
