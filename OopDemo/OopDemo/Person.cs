﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDemo
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual string FullName => $"{FirstName} {LastName}";
    }
}
