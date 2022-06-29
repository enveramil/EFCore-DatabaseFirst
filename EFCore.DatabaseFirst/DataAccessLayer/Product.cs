using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.DatabaseFirst.DataAccessLayer
{
    public class Product
    {
        // Veritabanındaki tablo da hangi sütunlar varsa burada property olarak tanımlayacağız.
        // Bu classın veritabanında bir karşılığı olduğu için aslında bir entity dir.
        public int id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
