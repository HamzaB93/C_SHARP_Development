using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPractice
{
    class Car
    {
        ////////////////////// Properties ///////////////////

        public string Manufacturer { get; set; }
        // Petrol or deisel
        public string Type { get; set;  }
        public int Mileage { get; set; }
        // True is full tank False needs filling
        public bool TankStatus { get; set; }

        /////////////////  Constructors ///////////////////

        // Default
        public Car()
        {
            Manufacturer = "Unknown";
            Type = "Petrol";
            Mileage = 0;
            TankStatus = true;
        }

        public Car(string manufacturer, string type, int mileage, bool tankStatus)
        {
            Manufacturer = manufacturer;
            Type = type;
            Mileage = mileage;
            TankStatus = tankStatus;
        }

        //////////////// Methods /////////////////

        // Drive the car to increase the Mileage
        public void Drive(int milesDriven)
        {
            Mileage += milesDriven;
            TankStatus = false;
        }

        // If amountOfFule is false, you need to fill up
        public string CheckTankStatus(bool amountOfFuel)
        {
            if (amountOfFuel)
                return "Your Tank is full.";
            else
                return "You need to fill up";

        }

        // Fill the tank and change the boolean to true 
        public void FillTank()
        {
            TankStatus = true;
        }

    }
}
