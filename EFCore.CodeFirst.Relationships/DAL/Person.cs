using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.CodeFirst.Relationships.DAL
{
    [Keyless]
    public class Person
    {
        // Owned olarak işaretlenmiş entityler de id bulunmaz!!!
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

    }
}
