using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // List of storable objects
            var storableObjects = new List<Storable>();
            
            // Treat the note nad dbentry as storable objects becaus they implment them
            Note myNote = new Note();
            storableObjects.Add(myNote);
            DBEntry myDBEntry = new DBEntry();
            storableObjects.Add(myDBEntry);

            myNote = new Note();
            storableObjects.Add(myNote);
            myDBEntry = new DBEntry();
            storableObjects.Add(myDBEntry);

            // Iterate over every Storable object called stoarble in the storable objects list
            foreach (Storable storable in storableObjects)
            {
                // Passing null because we dont want to pass an object
                // Depeding on the object being note or dbentry, write and read will act differently 
                storable.Write(null);
                Console.WriteLine(storable.Read());
            }
        }
    }
}
