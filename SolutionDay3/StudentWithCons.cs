using System;
using System.Collections.Generic;
using System.Text;

namespace StudentWithCons
{
   
    class Student
    {
        int rn;
        string name;
        static string batchCode;
        int marks;
        //Def
          Student()
        {

        }

        //Para
        public Student(int rn)
        {
            this.rn = rn;
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            //Console.WriteLine("Enter BatchCode");
            //batchCode = Console.ReadLine();
            Console.WriteLine("Enter Marks");
            marks = int.Parse(Console.ReadLine());
        }
        //Para
        public Student(int rn, string name)
        {
            this.rn = rn; 
            this.name = name;
            //Console.WriteLine("Enter BatchCode");
            //batchCode = Console.ReadLine();
            Console.WriteLine("Enter Marks");
            marks = int.Parse(Console.ReadLine());
        }
        //Para 
        public Student(int rn, string name, string batchCode, int marks)
        {
            this.rn = rn;
            this.name = name; 
            //this.batchCode = batchCode;
            this.marks = marks;
        }
         static Student()
        {
            batchCode = "B001";
        }
        // Copy 
        public Student(Student obj)
        {
            Console.WriteLine("Enter RollNo");
            rn = int.Parse(Console.ReadLine());
            this.name = obj.name;
            this.marks = obj.marks;
        }
        public void GetDetails()
        {
            Student student = new Student();
            Console.WriteLine("ENter RollNo");
            rn = Byte.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name");
            name = Console.ReadLine();
            //Console.WriteLine("Enter BatchCode");
            //batchCode = Console.ReadLine();
            Console.WriteLine("Enter Marks");
            marks = int.Parse(Console.ReadLine());
        }
        public void DisplayDetails()
        {
            Console.WriteLine("RollNo is " + rn);
            Console.WriteLine("Name is " + name);
          //  Console.WriteLine("Batch Code is " + batchCode);
            Console.WriteLine("Marks are " + marks);
        }
    }
}
