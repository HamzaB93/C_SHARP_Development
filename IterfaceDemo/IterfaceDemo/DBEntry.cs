using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterfaceDemo
{
    public class DBEntry : Storable
    {
        // Class implements storable differently than Note

        private ReturnStatus status;
        public ReturnStatus Status { get { return status; } set { status = value; } }

        public string Read()
        {
            return "Reading from a database...";
        }

        public void Write(object obj)
        {
            Console.WriteLine("Write obj to database...");
        }
    }
}
