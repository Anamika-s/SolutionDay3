using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SolutionDay3
{
    class ProgramEmp
    {
        static void Main()
        {
            //Employee employee = new Employee();
            //employee.Id = 90;
            //Console.WriteLine(employee.Id);

            //List<Employee> list = new List<Employee>();
            //list.Add(new Employee() { Id = 1, Name = "Ajay", DateOfJoining = DateTime.Parse("1/12/2009"), Department = "HR", Salary = 67000f });
            //list.Add(new Employee() { Id = 1, Name = "Ajay", DateOfJoining = DateTime.Parse("1/12/2009"), Department = "HR", Salary = 67000f });
            //list.Add(new Employee() { Id = 1, Name = "Ajay", DateOfJoining = DateTime.Parse("1/12/2009"), Department = "HR", Salary = 67000f });
            //list.Add(new Employee() { Id = 1, Name = "Ajay", DateOfJoining = DateTime.Parse("1/12/2009"), Department = "HR", Salary = 67000f });

            // Collection Initializer

            List<Employee> list = new List<Employee>()
            {
                 new Employee() { Id = 1, Name = "Ajay", DateOfJoining = DateTime.Parse("1/12/2009"), Department = "HR", Salary = 67000f },

                 new Employee() { Id = 2, Name = "Deepak", DateOfJoining = DateTime.Parse("1/12/2009"), Department = "HR", Salary = 67000f },
                 new Employee() { Id = 3, Name = "Sagar", DateOfJoining = DateTime.Parse("1/12/2009"), Department = "Sales", Salary = 67000f },
                 new Employee() { Id = 4, Name = "Ajay", DateOfJoining = DateTime.Parse("1/12/2009"), Department = "Sales", Salary = 67000f },
                 new Employee() { Id = 5, Name = "Ajay", DateOfJoining = DateTime.Parse("1/12/2009"), Department = "HR", Salary = 67000f }

            };

            foreach (Employee employee in list)
            {
                Console.WriteLine(employee.Id + " " + employee.Name + " " + employee.DateOfJoining + " " + employee.Department + " " + employee.Salary);
            }

            // Filter records

            Console.WriteLine("Employees of HR Department");
            foreach(Employee employee in list)
            {
                if(employee.Department =="HR")
                {
                    Console.WriteLine(employee.Name);
                }
            }

            // LINQ > Language integrated Query

            Console.WriteLine("Basic LINQ Query");
            var listofEmployees = (from temp in list
                                   select temp);

            foreach(var temp in listofEmployees)
                Console.WriteLine(temp.Id + " " + temp.Name);

            // Filter Records

            Console.WriteLine("Records of HR Dept");
            listofEmployees = (from temp in list
                               where temp.Department == "HR"
                               select temp);
            
            foreach (var temp in listofEmployees)
                Console.WriteLine(temp.Id + " " + temp.Name);

            listofEmployees = (from temp in list
                               where temp.Salary > 30000
                               select temp);

            listofEmployees = (from temp in list
                               where temp.Salary > 30000 && temp.Salary <= 70000
                               select temp);

            //  Method Syntax
            // Lambda Expression
            // Lambda OPerator 
            // (input)=>(output)
            listofEmployees = list.Select(x=>x);
            listofEmployees = list.Where(x => x.Department == "HR");



        }
    }
}
