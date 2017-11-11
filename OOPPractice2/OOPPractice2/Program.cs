using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.FuelStatus = 100;

            car1.Drive(50);

            car1.CheckFuelStatus(car1.FuelStatus);

            Hyrbrid hyb1 = new Hyrbrid();
            hyb1.Battery = 100;
            hyb1.FuelStatus = 100;

            hyb1.Drive(20, 0);
            hyb1.CheckFuelStatus(hyb1.FuelStatus, hyb1.Battery);
            hyb1.CheckFuelStatus(hyb1.FuelStatus);



        }
    }
}
