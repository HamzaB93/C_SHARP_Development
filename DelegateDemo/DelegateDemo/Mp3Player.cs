using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class Mp3Player
    {
        // We want this to match the delgate
        public int PlayMp3File()
        {
            Console.WriteLine("PLaying Mp3 file...");
            return 0;
        }
    }
}
