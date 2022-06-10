using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oovning5b
{
    
    internal class Garage//<T>:IEnumerable<T> where T : class
    {
        //public  Enumerator  GetEnumerator();
        private Oovning5b.UserInterface userInterface = new Oovning5b.UserInterface();
        public string Name { get; set; }
        private int Size { get; set; }
        private Vehicle[] parkedVehicles;

        public Garage(int numberOfSpots, string name)
        {
            this.parkedVehicles = new Vehicle[numberOfSpots];
            this.Name = name;
            this.Size = numberOfSpots;
        }

        public void ParkVehicle(Vehicle vehicle)
        {
            if (this.parkedVehicles.Length < Size - 1)
            {
                Array.Resize(ref parkedVehicles, parkedVehicles.Length + 1);
                parkedVehicles[parkedVehicles.Length] = vehicle;
                vehicle.GarageName = this.Name;
            }
            else 
            {
                string message = "Garage isd full, keep driving";
                userInterface.Message(message);
            }
            
        }

        public void UnParkVehicle(Vehicle vehicle)
        {
            parkedVehicles = parkedVehicles.Where(val => val != vehicle).ToArray();
            vehicle.GarageName = null;
        }

       
    }
}
