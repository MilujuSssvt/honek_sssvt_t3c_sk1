using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Teacher
    {
        public Name FullName { get; set; }
        public decimal Salary { get; set; }
        public Address ContactAddress { get; set; }

        public Student[] FavoriteStudents { get; set; }
    }
}
