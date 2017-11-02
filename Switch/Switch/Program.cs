using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pick a number between 1 and 6 ");
            int choice = int.Parse(Console.ReadLine());

            // Depending on the choice
            switch (choice)
            {
                // Do these
                // Case 6 falls onto case 5 and does the same thing
                case 6:
                case 5:
                    Console.WriteLine("You chose the highest legal value");
                    break;
                case 4:
                    Console.WriteLine("You chose 4");
                    break;
                case 3:
                    Console.WriteLine("You chose 3");
                    break;
                case 2:
                    Console.WriteLine("You chose 2");
                    break;
                case 1:
                    Console.WriteLine("You chose 1");
                    break;
                // If none were met do this
                default:
                    Console.WriteLine("YOu didnt chose a legal value, try again later!");
                    break;
            }

        }
    }
}
