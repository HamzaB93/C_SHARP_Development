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
            // Create new warehouse
            var newWarehouse = new Warehouse(101, "Warehouse 1");
            // use Findandreturnitem to get back an Item object
            var myItem = newWarehouse.FindAndReturnItem(101);

            Console.WriteLine("My new item is {0}", myItem.Name);
        }
    }
}
