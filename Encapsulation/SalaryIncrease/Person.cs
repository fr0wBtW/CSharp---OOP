﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryIncrease
{
    class Person
    {
        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public decimal Salary { get; private set; }

        public void IncreaseSalary(decimal percentage)
        {
            if(this.Age < 30)
            {
                percentage = percentage / 2;
            }
            this.Salary = this.Salary + ((this.Salary * percentage) / 100);
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:f2} leva.";
        }
    }
}
