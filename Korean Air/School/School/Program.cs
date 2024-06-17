namespace School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Name name = new Name("Vladimir", "Mrkacek");
            name.MiddleName = "Turek";

            Address address = new Address();

            Student student = new Student (name, "T3.C", address);
            student.Grades.Add(1);
            student.Grades.Add(3);
            student.Grades.Add(4);
            student.Grades.Add(1);
            student.Grades.Add(5);
            student.Grades.Add(2);
        }
    }
}
