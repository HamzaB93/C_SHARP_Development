using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            // Lists take the object they hold in angle bracket - List of ....
            List<int> myList = new List<int>();

            // Adding to list with a for loop
            for (int i = 0; i < 10; i++)
            {
                myList.Add(r.Next());
            }

            // Sort the list
            myList.Sort();

            // Show the contents of the list
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
        }
    }
}
