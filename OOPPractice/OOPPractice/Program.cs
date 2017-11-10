using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var newCar = new Car();

            Console.WriteLine("My cars Mileage is {0}", newCar.Mileage);

            newCar.Drive(100);
            var tank = newCar.CheckTankStatus(newCar.TankStatus);

            Console.WriteLine("... Now it's {0} and {1}", newCar.Mileage, tank);

            newCar.FillTank();
            Console.WriteLine(newCar.CheckTankStatus(newCar.TankStatus));

            
            
        }
    }
}
