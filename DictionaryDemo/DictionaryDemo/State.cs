using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    public class State
    {
        // Properties 
        public string Capital { get; set; }
        public int Population { get; set; }
        public int Size { get; set; }

        // Constructtor
        public State (string capital, int population, int size)
        {
            Capital = capital;
            Population = population;
            Size = size;
        }

        // Static method to get the states
        public static Dictionary<string, State> GetStates()
        {
            // Create a dictionary
            var states = new Dictionary<string, State>();
            // Create a state object
            var theState = new State("Mongomery", 123456, 123);
            //Add that state to the dictionary with a key
            states.Add("Alabama", theState);

            theState = new State("Juneau", 2468, 246);
            states.Add("Alaska", theState);

            return states;
        }
    }
}
