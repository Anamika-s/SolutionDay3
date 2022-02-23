using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionDay3
{
      class Student
    {
        int rn;
        string name;
        string batchCode;
        int marks;
        public void GetDetails()
        {
            Console.WriteLine("ENter RollNo");
            rn = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter BatchCode");
            batchCode = Console.ReadLine();
            Console.WriteLine("Enter Marks");
            marks = int.Parse(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            Console.WriteLine("RollNo is " + rn);
            Console.WriteLine("Name is " + name);
            Console.WriteLine("Batch Code is " + batchCode);
            Console.WriteLine("Marks are " + marks);
        }
    }
}
