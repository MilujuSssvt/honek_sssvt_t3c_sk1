using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class School
    {
        public School(string name, Address location)
        {
            Name = name;
            Location = location;

            Teachers = new List<Teacher>();
            Students = new List<Student>();
        }

        public  string Name { get; set; }
        public Address Location { get; set; }

        public List<Teacher> Teachers { get; set; }
        public List<Student> Students { get; set; }

        public Student GetBestStudentByClass(string className)
        {
            return Students
                .Where(student => student.Class == className)
                .MinBy(Student => Student.GetGradesAverage());
        }

        public decimal GetAverageTeacherSalary()
        {
            return Teachers.Average(Teacher => Teacher.Salary);
        }

    }
}
