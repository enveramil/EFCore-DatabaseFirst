﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.CodeFirst.Relationships.DAL
{
    public class Teacher
    {
        public int Id { get; set; }

        public string Name { get; set; }

        // Navigation Property
        public List<Student> Students { get; set; }

    }
}
