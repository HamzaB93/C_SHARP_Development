﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }

        // All classes that inherit from item will have this class
        public virtual void Purchase ()
        {
            Console.WriteLine("Purchasing {0}", Name);
        }

        //public static Item GetItem()
        //{
        //    var newItem = new Item { ID = 101, Name = "My Item" };
        //    return newItem;
        //}

        // Get list of items
        public static List<Item> GetItems(int numsToGet)
        {
            // Generate a random number
            var random = new Random();
            // MAke new list 
            var newList = new List<Item>();
            // Define new item
            Item newItem;
            
            // Iterate the amount of numbers to get
            for (int i = 0; i < numsToGet; i++)
            {
                // Assign values to the newItem we defined
                newItem = new Item { ID = random.Next(), Name = "My Item " + i.ToString() };
                newList.Add(newItem);
            }
            // Return the populated list
            return newList;
        }
    }

    // Software derives the Item class
    // Software IS A item
    class Software : Item
    {
        public string ISBN { get; set; }

        public override void Purchase()
        {   // Dont need base method, can have totally new logic
            //base.Purchase();
            Console.WriteLine("My ID is {0} and my ISBN is {1}", ID, ISBN);
        }
    }

    class Hardware : Item
    {
        public string SerialNumber { get; set; }
    }

    // Computer is hardware, which is an item and has a seriesl number and other properties
    class Computer : Hardware
    {
        public string CPUType { get; set; }
        public string Disks { get; set; }

        //Overrding purchase to get it to work differntly rather than hwo it was inherted
        public override void Purchase()
        {
            // Calls the base functionality from Item
            base.Purchase();
            // Giving extra function
            Console.WriteLine("My CPU type is {0}", CPUType);
        }
    }

    class Peripheral : Hardware
    {
        public string Description { get; set; }
    }

}