using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionDay3
{
    class ArrayOfObjects
    {
        static void Main()
        {
            // Array of Objects
            Student[] students = new Student[10];
            for (int i = 0; i < 3; i++)
            {
                students[i] = new Student();
                Console.WriteLine("Enter Details of " + (i + 1) + " Student");
                students[i].GetDetails();
            }
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Details of " + (i + 1) + " Student");
                students[i].DisplayDetails();
            }
        }
    }
}