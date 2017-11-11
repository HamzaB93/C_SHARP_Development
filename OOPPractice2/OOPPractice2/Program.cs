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
            Car car1 = new Car("Vauxhall", "11EZUP", false, 100);
            car1.Drive(2);
            car1.CheckFuelStatus(car1.FuelStatus);

            Hybrid hyb1 = new Hybrid("Toyota", "EE1155F", true, 100, 100);
            hyb1.Drive(30, 1);
            hyb1.CheckFuelStatus(hyb1.FuelStatus, hyb1.Battery);

            PetrolCar pet1 = new PetrolCar("VW", "441FUY", true, 55);
            DieselCar dies1 = new DieselCar("BMW", "E1161", false, 100);

            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(car1);
            vehicles.Add(hyb1);
            vehicles.Add(pet1);
            vehicles.Add(dies1);

            foreach (Vehicle v in vehicles)
            {
                Console.WriteLine("Name: {0}, Reg: {1}, Insurance: {2}, Fuel: {3}",
                    v.Name, v.Registration, v.Insurance, v.FuelStatus);
            }

        }
    }
}
