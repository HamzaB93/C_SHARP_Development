using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Warehouse
    {
        public int ID { get; set; }
        public string WarehouseName { get; set; }

        // Constructor
        public Warehouse( int ID, string Name)
        {
            // Assign the ID to this object
            this.ID = ID;
            WarehouseName = Name;
        }

        // Return an Item object that takes a itemId
        public Item FindAndReturnItem(int itemId)
        {
            // Initialise an Item
            Item returnItem = new Item() { ID = itemId, Name = "Microsoft Office" };
            // Return the item
            return returnItem;
        }
    }
}
