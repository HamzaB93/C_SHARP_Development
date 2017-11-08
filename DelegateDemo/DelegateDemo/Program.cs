using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create instances of Tester, mp3 and mp4
            var tester = new MediaTester();
            var mp3 = new Mp3Player();
            var mp4 = new Mp4Player();

            // Calling the delgate, where the delgate is, the name of it and the method that will
            // return the correct type and has the right amount of params
            var mp3Delgate = new MediaTester.TestMedia(mp3.PlayMp3File);
            var mp4Delgate = new MediaTester.TestMedia(mp4.PlayMp4File);

            // tester > run RUntest > call through the mp3delgate > PlayMp3 File
            tester.RunTest(mp3Delgate);
            tester.RunTest(mp4Delgate);
        }
    }
}
