using System;
using System.Collections.Generic;
using System.Text;

namespace StudentWithCons
{
    class CallingStudentWithCons
    {
        static void Main()
        {
            // 1. Static cons will be always invoked first
            // This will invoke def cons
         //   Student s1 = new Student();
            //s1.GetDetails();
            //s1.DisplayDetails();
            // This will invoke para cons
            Student s2 = new Student(10);
            s2.DisplayDetails();
            // This will invoke para cons
            Student s3 = new Student(12, "Ajay");
            s3.DisplayDetails();
            // This will invoke copy cons
            Student s4 = new Student(s3);
            s4.DisplayDetails();
        }
    }
}
