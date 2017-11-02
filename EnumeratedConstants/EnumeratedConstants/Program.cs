using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratedConstants
{
    class Program
    {
        enum Colour
        {
            Red,
            Orange,
            Green,
            Blue,
            Indigo,
            Violet
        }

        static void Main(string[] args)
        {
            Colour favourite = Colour.Green;

            switch (favourite)
            {
                case Colour.Red:
                    Console.WriteLine("You chose Red");
                    break;
                case Colour.Violet:
                    Console.WriteLine("You chose Violet");
                    break;
                case Colour.Orange:
                    Console.WriteLine("You chose Orange");
                    break;
                case Colour.Indigo:
                    Console.WriteLine("You chose Indigo");
                    break;
                case Colour.Green:
                    Console.WriteLine("You chose Green");
                    break;
                case Colour.Blue:
                    Console.WriteLine("You chose Blue");
                    break;
                default:
                    Console.WriteLine("WRONG COLOUR SORRRRRY!");
                    break;

            }

        }
    }
}
