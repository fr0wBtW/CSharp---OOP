using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mankind
{
   public class Human
    {
        private string firstName { get; set; }
        private string lastName { get; set; }

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public virtual string FirstName
        {
            get { return firstName; }
            set
            {
                if (!char.IsUpper(value.First()))
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");

                if(value.Length<=3)
                    throw new ArgumentException("Expected length at least 4 symbols! Argument: firstName");

                firstName = value;
            }
        }
        public virtual string LastName
        {
            get { return lastName; }
            set
            {
                if (!char.IsUpper(value.First()))
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");

                if (value.Length < 3)
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName ");

                lastName = value;
            }
        }
    }
}
