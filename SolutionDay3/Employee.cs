using System;
using System.Collections.Generic;
using System.Text;

namespace SolutionDay3
{
    class Employee
    {
        // properties are wrapper around private variables
        //int id;
        //public int Id
        //{
        //    get
        //    {
        //        return id;
        //    }
        //    set
        //    {
        //        id = value;

        //    }
        //}
        //private int id;

        //public int Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}
        //public int Id { get; private set; }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public float Salary { get; set; }
        public DateTime DateOfJoining { get; set; }



    }
}
