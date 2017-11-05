using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //var items = new Item[5];
            //// Create pseudo random numbers
            //Random r = new Random();
            //// Iterate thorugh the array and populate it
            //for (int i = 0; i < items.Length; i++)
            //{
            //    // At the index generate a number and assign it to the index
            //    items[i] = new Item(r.Next());
            //}

            //Console.WriteLine("Items: ");

            //// For each item in the items collection, do something with it
            //foreach (Item item in items)
            //{
            //    Console.WriteLine("ItemID = {0}", item.ID);
            //}

            //// Get the second item in the array
            //Item myItem = items[1];
            //Console.WriteLine("ID of second item = {0}", myItem.ID);

            //// Will get error if we want an item that is past the offset of the array
            //// If we wanted the 5th item we should ask for what is at the 4th location as it starts from 0
            //Item myOtherItem = items[5];
            //Console.WriteLine("ID of second item = {0}", myOtherItem.ID);

            // Array of strings 
            var Authors = new String[5];
            Authors[0] = "Faulkner";
            Authors[1] = "Proust";
            Authors[2] = "Stephenson";
            Authors[3] = "Gibson";
            Authors[4] = "Melville";

            Console.WriteLine("Authors...");
            foreach (string s in Authors)
            {
                Console.WriteLine(s);
            }

            // Can sort the authors array using the Array method
            Array.Sort(Authors);
            Console.WriteLine("Authors...");
            foreach (string s in Authors)
            {
                Console.WriteLine(s);
            }

        }
    }
}
