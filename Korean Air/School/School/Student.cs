using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Student
    {
        public Student(Name fullName, string @class, Address contactAddress)
        {
            FullName = fullName;
            Class = @class;
            ContactAddress = contactAddress;

            Grades = new List<int>();
        }

        public Name FullName { get; set; }
        public string Class {  get; set; }
        public Address ContactAddress { get; set; }
        public List<int> Grades { get; set; }

        public int GetWorstGrades()
        {
            int worstGrade = Grades.Max();
            return worstGrade;
        }

        public int GetBestGrades()
        {
            int bestGrade = Grades.Min();
            return bestGrade;
        }

        public double GetGradesAverage()
        {
            return Grades.Average();
        }
    }
}
