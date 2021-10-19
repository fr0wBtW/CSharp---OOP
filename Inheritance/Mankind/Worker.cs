﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
    class Worker : Human
    {
        private decimal salary;
        private decimal workingHours;

        public Worker(string firstName, string lastName, decimal salary, decimal workingHours)
            : base(firstName, lastName)
        {
            this.Salary = salary;
            this.WorkingHours = workingHours;
        }

        public decimal Salary
        {
            get { return salary; }
            set
            {
                if (value <= 10)
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");

               salary = value;
            }
        }
        public decimal  WorkingHours
        {
            get { return workingHours; }
            set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");

              workingHours = value;
            }
        }
        public override string ToString()
        {
            return $"First Name: {this.FirstName}" + Environment.NewLine +
               $"Last Name: {this.LastName}" + Environment.NewLine +
               $"Week Salary: {this.Salary:f2}" + Environment.NewLine +
               $"Hours per day: {this.WorkingHours:f2}" + Environment.NewLine +
               $"Salary per hour: {getSalaryPerHour():f2}";
        }
        private decimal getSalaryPerHour()
        {
            return this.salary / 5 / this.workingHours;
        }
    }
}
