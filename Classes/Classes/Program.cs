using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Employee
    {
        //// Backing variable
        //private int age;
        //public int Age
        //{
        //    //return prvate variable
        //    get { return age; }
        //    // Sets the private variable age
        //    // Value is hidden parameter that i passed into set
        //    set { age = value; }
        //}

        public int Age { get; set; }
        public string Name { get; set; }

        //// Returns the employees age
        //public int MyAge()
        //{
        //    return age;
        //}
        //// Set the age
        //public void SetAge(int someAge)
        //{
        //    age = someAge;
        //}
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Employee
            Employee Dave = new Employee();

            // Set is automatically called
            Dave.Age = 35;

            //// Giving dave an age
            //Dave.SetAge(24);

            //// Returns the age
            //int age = Dave.MyAge();

            // Get the age and getter is automatically called
            Console.WriteLine("Dave's age is {0}", Dave.Age);
        }
    }
}
