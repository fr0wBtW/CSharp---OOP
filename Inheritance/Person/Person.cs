﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    public class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        private string name;
        private int age;

        public virtual string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 3)
                    throw new ArgumentException("Name's should not be less than 3 symbols!");
                name = value;
            }
        }
        public virtual int Age
        {
            get { return age; }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("Age must be positive!");
                }
                age = value;
            }
        }
        public override string ToString()
        {
            return $"Name: {this.Name}, Age: {this.Age}";
        }
    }
}
