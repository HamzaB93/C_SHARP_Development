using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Declaring dictionary idenitfy the key and value
            //Dictionary<string, string> capitals = new Dictionary<string, string>();

            //// Adding to the dictionary first value is key, the second is value
            //capitals.Add("Alabama", "Mont");
            //capitals.Add("Alaska", "June");
            //capitals.Add("Arizona", "Pheonix");
            //capitals.Add("Massa", "Boston");
            //capitals.Add("Wyomiing", "chey");

            //// To extract from a dictionary, give the key 
            //string capitalOfMassa = capitals["Massa"];
            //Console.WriteLine("Capital of massa is {0} ", capitalOfMassa);

            // Get the dictionary of states were the key is a string and the value is a State
            var theStates = State.GetStates();
            // You idenitfy the key and get the STATE object then ask for the captial which is a string
            //string captitalOfAlaska = theStates["Alaska"].Capital;
            //Console.WriteLine("THe captical of Alaska is {0}", captitalOfAlaska);

            var theState = theStates["Alaska"];
            Console.WriteLine("The capital of Alaska is {0}, its population is {1} and its {2} square miles",
                theState.Capital, theState.Population, theState.Size);
        }
    }
}
