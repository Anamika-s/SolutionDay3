using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionDay3
{
    class MainProgramWithStaticVariable
    {
       static void Main()
        {
            // StudentWithStaticVariable.Student student = new StudentWithStaticVariable.Student();
            //StudentWithStaticVariable.Student.batchCode = "B001";
            //Console.WriteLine("Batch Code is " + StudentWithStaticVariable.Student.batchCode);
            StudentWithStaticVariable.Student.DisplayBatch();
            List<StudentWithStaticVariable.Student> list = new List<StudentWithStaticVariable.Student>();
            string ch = "y";
            while (ch == "y")
            {
                StudentWithStaticVariable.Student student = new StudentWithStaticVariable.Student();
                student.GetDetails();
                list.Add(student);
                Console.WriteLine("Do you want to enter more records");
                ch = Console.ReadLine();
            }
            //list.Add(1);
            //list.Add(90.7F);

            foreach (StudentWithStaticVariable.Student student in list)
            {
                student.DisplayDetails();
            }


        }
    }
}
