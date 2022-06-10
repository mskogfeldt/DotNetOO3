using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oovning5b
{
    internal class GarageService
    {
        //bool keepWorkin = true;
        private Oovning5b.UserInterface userInterface = new Oovning5b.UserInterface();
        public Dictionary<string, Vehicle> numberPlates = new Dictionary<string, Vehicle>();
        public Dictionary<string, Garage> garages = new Dictionary<string, Garage>();



        public void AddGarage(int numberOfSpots, string name)
        {
            Garage newGarage = new Garage(numberOfSpots, name);
            garages.Add(name, newGarage);
        }

        //public void AdminGarageMenu(string licensPlate, string garageName)
        public void ParkVehicle(Vehicle vehicle, Garage garage)
        {
            if (vehicle.GarageName != null)
            {
                if (vehicle.GarageName == garage.Name)
                {
                    string message = "Car is already parked at said garage";
                    userInterface.Message(message);
                }
                else
                {
                    Garage oldGarage = garages.GetValueOrDefault(vehicle.GarageName);
                    oldGarage.UnParkVehicle(vehicle);
                    garage.ParkVehicle(vehicle);
                }
            }
        }

        public void UnParkVehicle(Vehicle vehicle)
        {
            if (vehicle.GarageName != null)
            {
                Garage oldGarage = garages.GetValueOrDefault(vehicle.GarageName);
                oldGarage.UnParkVehicle(vehicle);
            }
        }





    }
}
