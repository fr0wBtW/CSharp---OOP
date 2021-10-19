using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortPersonsByNameAndAge
{ 
    class Person
    {
        public Person(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string firstName { get;private set; }
        public string lastName { get; private set; }
        public int age { get; private set; }

        public override string ToString()
        {
           return $"{this.firstName} {this.lastName} is {this.age} years old.";
        }
    }
}
