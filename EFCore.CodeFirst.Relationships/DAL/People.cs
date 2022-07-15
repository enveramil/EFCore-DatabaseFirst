using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.CodeFirst.Relationships.DAL
{
    public class People
    {
        public int Id { get; set; }
        public string Name { get; set; }    
        public string PhoneNumber { get; set; }
    }
}
