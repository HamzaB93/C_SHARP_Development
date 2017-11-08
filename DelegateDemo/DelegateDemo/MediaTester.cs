using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class MediaTester
    {
        // Run a test using any method of any class that takes no arguments and return a int
        // were 1 id fail and 0 is success

        // Say that TEstMedia is a delgate that returns an int but takes no arguemnts
        public delegate int TestMedia();

        // Takes an instance of a test media of one the delegate 
        public void RunTest(TestMedia testDelegate)
        {
            // Call a metthod that is encapsulated in the delgate
            int result = testDelegate();

            if (result == 0 )
            {
                Console.WriteLine("Works!");
            }
            else
            {
                Console.WriteLine("Failed.");
            }
        }
    }
}
