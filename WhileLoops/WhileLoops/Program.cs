using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask how old
            Console.Write("How old are you? ");
            // Call console read line and pass it as parameter to the parse function of int and assign to age
            int age = int.Parse(Console.ReadLine());

            // do the work once then check do the test
            do
            {
                Console.Write("Happy Birthday! ");
                age--;
            } while (age > 0);

            // While age is greater than 0
            //while (age > 0)
            //{
            //    Console.Write("Happy Birthday! ");
            //    age--;
            //}

            Console.Write("\nTADA!!");
        }
    }
}
