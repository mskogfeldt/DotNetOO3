namespace Oovning5b
{
    internal class Airplane : Vehicle
    {

        public int Wingspan { get; set; }

        public Airplane(string regnr, string color, int wheels, string garageName, int wingspan) : base(regnr, color, wheels, garageName)
        {
            Wingspan = wingspan;
        }


        public override string VehicleInfo()
        {
            return base.VehicleInfo() + $"Wingspan: {Wingspan}";
        }
    }
}
