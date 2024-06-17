using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Name
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            if (!string.IsNullOrWhiteSpace(MiddleName))
            {
                return $"{FirstName} {MiddleName} {LastName}";
            }

            return $"{FirstName} {LastName}";
        }
    }
}
