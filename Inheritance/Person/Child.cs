﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Child : Person
    {
        public Child(string name, int age)
            : base(name, age)
        {
            this.Age = age;
        }
        public override int Age
        {
            get
            {
                return base.Age;
            }
            set
            {
                if (value > 14)
                    throw new ArgumentException("Child's age must be less than 15!");
                base.Age = value;
            }
        }
    }
}
