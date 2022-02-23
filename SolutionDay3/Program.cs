using System;

namespace SolutionDay3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            //Student student;
            //student = new Student();
            //Student student = new Student();
            //student.GetDetails();
            //student.DisplayDetails();
            int n1, n2, n3;
            Console.WriteLine("Studnet 1");
            Student student1 = new Student();
            student1.GetDetails();
            student1.DisplayDetails();

            Console.WriteLine("Studnet 2");
            Student student2 = new Student();
            student2.GetDetails();
            student2.DisplayDetails();

            Console.WriteLine("Studnet 3");
            Student student3 = new Student();
            student3.GetDetails();
            student3.DisplayDetails();
        }
    }
}
