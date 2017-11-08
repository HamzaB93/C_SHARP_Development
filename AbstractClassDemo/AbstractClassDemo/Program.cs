using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp1 = new Worker();
            emp1.Name = "David";
            emp1.Salary = 50000;

            var emp2 = new Manager();
            emp2.Name = "Rachel";
            emp2.Salary = 1000000;

            var emp3 = new Manager();
            emp3.Name = "Zach";
            emp3.Salary = 150000;

            // Can add all these Employees to the list as they all derive from the Employee class
            var employees = new List<Employee>();
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);

            // Iterate through the list and give each one a raise
            foreach (Employee emp in employees)
            {
                Console.Write("{0}'s salary was {1}", emp.Name, emp.Salary);
                //OVerriden differently depending on type of employee
                emp.GiveRaise();
                Console.WriteLine(" but is now {0}", emp.Salary);
            }
        }
    }
}
