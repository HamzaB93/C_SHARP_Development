using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterfaceDemo
{
    // Our class implements the interface, same notaton as inheritance
    // If Note dervied from another class, the base class will be first then the interface
    public class Note : Storable
    {
        private ReturnStatus status;

        public ReturnStatus Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }

        public string Read()
        {
            return "Reading note from disk";
        }

        public void Write(object obj)
        {
            Console.WriteLine("Writing obj to dosk...");
        }

        public void OtherMethod()
        {
            Console.WriteLine("Some other method...");
        }
    }
}
