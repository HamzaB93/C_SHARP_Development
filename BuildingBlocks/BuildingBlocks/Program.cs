using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingBlocks
{
    class Program
    {
        static void Main(string[] args)
        {
            var myVariable = "Hello World";
            Console.WriteLine(myVariable);

            int myFirstValue = 23;
            double mySecondValue = 45.34;
            // int is being converted to double here
            double sum = myFirstValue + mySecondValue;
            Console.WriteLine(sum);

        }
    }
}
