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
             //garage.Par
        }

        public void UnParkVehicle(string registrationNumber, string garageName)
        {

        }





    }
}
