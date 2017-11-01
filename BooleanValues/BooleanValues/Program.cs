using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooleanValues
{
    class Program
    {
        static void Main(string[] args)
        {
            // Evluate if 3 + 2 Equals to 5
            // Will be true
            bool myFirstBoolean = 3 + 2 == 5;
            Console.WriteLine(myFirstBoolean);

            // Evluate is 3 + 2 is greater than 5
            // Will be false
            bool mySecondBoolean = 3 + 2 > 5;
            Console.WriteLine(mySecondBoolean);

            // AND is true when both statements are true. 
            bool bothAreTrue = myFirstBoolean && mySecondBoolean;
            // Will be false
            Console.WriteLine("bothAreTRue evlautes " + bothAreTrue);

            // OR is true when one of the expressions is true
            // Will be true
            bool oneIsStrue = myFirstBoolean || mySecondBoolean;
            Console.WriteLine("onIsTrue evaluates {0} because one expression evluates true", myFirstBoolean);

            // Using NOT to reverse myfirstboolean to false
            bool reverseMyFirstBoolean = !myFirstBoolean;
            Console.WriteLine("myFirstBoolean is {0} but reverseMyFirstBoolean is {1}", 
                myFirstBoolean, reverseMyFirstBoolean);

        }
    }
}
