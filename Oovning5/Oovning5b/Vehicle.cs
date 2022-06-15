namespace Oovning5b
{
    abstract class Vehicle
    {
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public int Wheels { get; set; }
        public string? GarageName { get; set; }


        public Vehicle(string regnr, string color, int wheels, string garageName)
        {
            RegistrationNumber = regnr;
            Color = color;
            Wheels = wheels;
            GarageName = garageName;
        }

        public virtual string VehicleInfo()
        {
            return $"License Plate: {RegistrationNumber}  |  Color: {Color}...";
        }
    }
}
