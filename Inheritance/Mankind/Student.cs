﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    class Student : Human
    {
        private string facultyNumber;

       public Student (string firstName, string lastName, string facultyNumber) : base(firstName,lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get {return facultyNumber; }
            set
            {
                if (value.Length < 5 || value.Length > 10)
                    throw new ArgumentException("Invalid faculty number!");

                if (!value.All(x => char.IsLetterOrDigit(x)))
                    throw new ArgumentException("Invalid faculty number!");

                this.facultyNumber = value;
            }
        }
        public override string ToString()
        {
            return $"First Name: {this.FirstName}" + Environment.NewLine +
             $"Last Name: {this.LastName}" + Environment.NewLine +
             $"Faculty number: {this.FacultyNumber}";
        }
    }
}
