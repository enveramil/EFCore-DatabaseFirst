using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreProcedured.Model
{
    public class ProductWithFeatures
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public decimal? ScreenSize { get; set; }

        public int? BateryCapacity { get; set; }

    }
}
