using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes2
{
    class Employee
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
        public DateTime StartingDate { get; set; }
        public string PhoneNumber { get; set; }

        // COnstructors
        public Employee(int age, string name, double salary, DateTime startDate, string phoneNumber)
        {
            Age = age;
            Name = name;
            Salary = salary;
            StartingDate = startDate;
            PhoneNumber = phoneNumber;
        }

        //Default constructor
        public Employee()
        {

        }

        // A standard method of a class
        // Doesnt return value, takes argument 
        public void Bonus (double bonusPercent)
        {
            // Adds to salary
            Salary += Salary * bonusPercent;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            // Initislise all field for the object
            Employee Dave = new Employee()
            {
                Age = 35,
                Name = "David Smith",
                Salary = 50000.00,
                StartingDate = new DateTime(2012, 7, 10),
                PhoneNumber = "0777772323"

            };
            Console.WriteLine("Dave's age is {0} he started on {1} and makes {2}",
                Dave.Age, Dave.StartingDate, Dave.Salary);

            Dave.Bonus(0.05);
            Console.WriteLine("Dave's age is {0} he started on {1} and makes {2}",
                Dave.Age, Dave.StartingDate, Dave.Salary);

            // Created employee by passing in values through arguments
            Employee Mary = new Employee(25, "Mary Jones", 60000.00, new DateTime(2012,11,1) , "998822999");
            Console.WriteLine("Mary's age is {0} he started on {1} and makes {2}",
                Mary.Age, Mary.StartingDate, Mary.Salary);

            //// One way of giving the instace data is to assign
            //Dave.Age = 35;
            //Console.WriteLine("Dave's age is {0}", Dave.Age);
        }
    }
}
