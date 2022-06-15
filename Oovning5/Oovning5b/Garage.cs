using System.Collections;

namespace Oovning5b
{

    internal class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        //public  Enumerator  GetEnumerator();
        private Oovning5b.UserInterface userInterface = new Oovning5b.UserInterface();
        public string Name { get; set; }
        public int Size { get; }
        private T[] parkedVehicles;

        public Garage(int numberOfSpots, string name)
        {
            this.parkedVehicles = new T[numberOfSpots];
            this.Name = name;
            this.Size = numberOfSpots;
        }

        public void ParkVehicle(T vehicle)
        {
            if (this.parkedVehicles.Length < Size - 1)
            {
                //just add vehicle to garage, also GarageName to vehicle
                Array.Resize(ref parkedVehicles, parkedVehicles.Length + 1);
                parkedVehicles[parkedVehicles.Length] = vehicle;
                vehicle.GarageName = this.Name;
                string message = "Registration number " + vehicle.RegistrationNumber + " is now parked at" + this.Name;
                userInterface.Message(message);
            }
            else
            {
                string message = this.Name + " is full, keep driving";
                userInterface.Message(message);
            }

        }

        public void UnParkVehicle(T vehicle)
        {
            parkedVehicles = parkedVehicles.Where(val => val != vehicle).ToArray();
            string message = "Registration number " + vehicle.RegistrationNumber + " is now leaving" + this.Name;
            userInterface.Message(message);
            vehicle.GarageName = null;

        }

        public IEnumerator<T> GetEnumerator()
        {
            //Hanera vad som ska returneras
            foreach (var v in parkedVehicles)
            {
                //Validera att det finns ett faktiskst fordon på platsen
                if (v is not null)
                {
                    yield return v;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    }
}
