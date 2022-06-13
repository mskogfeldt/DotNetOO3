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
        public Dictionary<string, Garage<Vehicle>> garages = new Dictionary<string, Garage<Vehicle>>();




        public void AddGarage(int numberOfSpots, string name)
        {
            var newGarage = new Garage<Vehicle>(numberOfSpots, name);
            garages.Add(name, newGarage);
        }

        //public void AdminGarageMenu(string licensPlate, string garageName)
        public void ParkVehicle(Vehicle vehicle, Garage<Vehicle> garage)
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
                    var oldGarage = garages.GetValueOrDefault(vehicle.GarageName);
                    //Null check, line 29 thou
                    oldGarage.UnParkVehicle(vehicle);
                    garage.ParkVehicle(vehicle);
                }
            }
            else 
            {
                garage.ParkVehicle(vehicle);
               // Console.WriteLine("Does not seem to work if vehile that is not parked already whants to park in garage.");
            }
        }

        public void UnParkVehicle(Vehicle vehicle)
        {
            if (vehicle.GarageName != null)
            {
                var oldGarage = garages.GetValueOrDefault(vehicle.GarageName);
                oldGarage.UnParkVehicle(vehicle);
            }
            else 
            {
                string message = ("Vehicle with registration number: " + vehicle.RegistrationNumber + " is not parked");
                userInterface.Message(message);
            }
            
        }

        public bool RegNOExists(string regno)
        {
            return garages[regno].Any(v => v.RegistrationNumber == regno);
        }

        public void GarageNames()
        {
            foreach (var garage in garages) userInterface.Message(garage.Key);
        }

    }
}
