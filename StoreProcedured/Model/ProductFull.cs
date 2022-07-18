using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProcedured.Model
{
    public class ProductFull
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public string CategoryName { get; set; }

        public decimal? ScreenSize { get; set; }

        public int? BateryCapacity { get; set; }

    }
}
