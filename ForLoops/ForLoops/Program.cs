using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop , setup value, test the value, change the value
            //for (int age = 5; age > 0; age--)
            //{
            //    // The work you do
            //    Console.WriteLine("Happy birthday! ");
            //}
            //Console.WriteLine("\nTA DA! ");

            // Set counter, test it then do action and then increment (Will run 10 times)
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write("Happy birthday! ");
            //}
            //Console.WriteLine("\nTA DA! ");

            //
            //int i = 0;
            //// Forever loop
            //for (;;)
            //{
            //    ++i;
            //    if (i == 5)
            //    {
            //        continue;
            //    }
            //    Console.Write("Happy birthday! {0} ", i);
                
            //    // If the condionts is true
            //    if (i > 10)
            //    {
            //        // COme out of loop
            //        break;
            //    }
            //}
            //Console.Write("\nTA DA! ");


            for ( int i = 0; i < 2000; i++)
            {
                if (i % 100 == 0)
                {
                    Console.Write("Happy Birthday!! {0}", i);
                }
            }
        }
    }
}
