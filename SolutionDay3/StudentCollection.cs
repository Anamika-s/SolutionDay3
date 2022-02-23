using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SolutionDay3
{
    class StudentCollection
    {
        static void Main()
        {
            //  ArrayList list = new ArrayList();
            List<Student> list = new List<Student>();
            string ch = "y";
            while(ch=="y")
            {
                Student student = new Student();
                student.GetDetails();
                list.Add(student);
                Console.WriteLine("Do you want to enter more records");
                ch = Console.ReadLine();
            }
            //list.Add(1);
            //list.Add(90.7F);

            foreach (Student student in list)
            {
                student.DisplayDetails();
            }
        }
         
    }
}
