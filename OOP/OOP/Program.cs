using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //var myComputer = new Computer();
            //myComputer.ID = 102;

            //// All computers are items so we make a computer which is of type item
            //Item mySecondComputer = new Computer();
            //// Only get the name and id as we only created it as an item
            //mySecondComputer.ID = 103;
            //// Take mySecondCOmputer and treat it as a computer instead of just an item
            //Computer mySecondComputer2 = mySecondComputer as Computer;
            //mySecondComputer2.CPUType = "i7";
            //string myCPUType = mySecondComputer2.CPUType;

            //mySecondComputer.Name = "Jupiter";
            //// COmputer didnt have the method but inherited it
            //mySecondComputer2.Purchase();

            //Software mySoftware = new Software();
            //mySoftware.ID = 101;
            //mySoftware.Name = "Foo";
            //mySoftware.ISBN = "1234";
            //mySoftware.Purchase();


            //Item someItem = new Item();
            Item newItem = Item.GetItem();

            Console.WriteLine ("New Item ID  = {0}, Name = {1}", newItem.ID, newItem.Name);
        }
    }
}
