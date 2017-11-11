using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice2
{
    class Vehicle
    {
        // Properties
        public string Name { get; set; }
        public string Registration { get; set; }
        public bool Insurance { get; set; }
        // Fuel out of 100
        public int FuelStatus { get; set; }

        public virtual void CheckFuelStatus(int amountOfFuel)
        {
            if (amountOfFuel == 100)
                Console.WriteLine("Your tank is full.");
            else if (amountOfFuel < 100 && amountOfFuel > 20)
                Console.WriteLine("You need to fill up the tank");
            else
                Console.WriteLine("Your tank is empty, you need to fill up otherwise you cant drive");
        }

        public void Drive(int fuelUsed)
        {
            FuelStatus -= fuelUsed;
        }

        public void FillUpFuel(int fuelToFillUp)
        {
            FuelStatus += fuelToFillUp;
        }
    }
    // Inheritance Car is a vehicle
    class Car : Vehicle
    {
        
    }
    // A petrol car is a car
    class PetrolCar : Car
    {
        public override void CheckFuelStatus(int amountOfFuel)
        {
            if (amountOfFuel == 100)
                Console.WriteLine("Your tank is full.");
            else if (amountOfFuel < 100 && amountOfFuel > 20)
                Console.WriteLine("You need to fill up the tank with pertrol");
            else
                Console.WriteLine("Your tank is empty, you need to fill up with petrol otherwise you cant drive");
        }

    }
    // A deisel car is a car
    class DieselCar : Car
    {
        public override void CheckFuelStatus(int amountOfFuel)
        {
            if(amountOfFuel == 100)
                Console.WriteLine("Your tank is full.");
            else if (amountOfFuel < 100 && amountOfFuel > 20)
                Console.WriteLine("You need to fill up the tank with diesl");
            else
                Console.WriteLine("Your tank is empty, you need to fill up with diesel otherwise you cant drive");
        }
    }

    class Hyrbrid : PetrolCar
    {
        public int Battery { get; set; }

        // Overloading
        public void CheckFuelStatus(int amountOfFuel, int battery)
        {
            if (amountOfFuel == 100 && battery == 100)
            {
                Console.WriteLine("Your fuel and battery are at {0}, youre full.", amountOfFuel);
            }
            else if (amountOfFuel < 100 && battery == 100)
            {
                Console.WriteLine("Your fuel is at {0}, but your battery is at {1}. Youre covered", amountOfFuel, battery);
            }
            else
                Console.WriteLine("Fill both fuel and battery");
        }

        public void Drive(int fuelUsed, int batteryUsed)
        {
            FuelStatus -= fuelUsed;
            Battery -= batteryUsed;
        }
    }

}
