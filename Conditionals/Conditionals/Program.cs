using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    class Program
    {
        static void Main(string[] args)
        {
            // .Write doesnt make a line after 
            Console.Write("What is you age? ");
            // .ReadLine reads text 
            string ageAsString = Console.ReadLine();
            // Save the string age as int
            int age = int.Parse(ageAsString);

            // IF this is true 
            if (age > 65)
            {
                // do this
                Console.WriteLine("You are a senior citizen");
            }
            // otherise
            else if (age >= 21)
            {
                // do this
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("You are not yet a legal adult");
            }

        }
    }
}
