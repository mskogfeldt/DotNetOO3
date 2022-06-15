namespace Oovning5b
{
    internal class Car : Vehicle
    {

        public int Doors;

        public Car(string regnr, string color, int wheels, string garageName, int doors) : base(regnr, color, wheels, garageName)
        {
            Doors = doors;
        }



        /*  public string RegistrationNumber { get; set; }
          public string Color { get; set; }
          public int Wheels { get; set; }
          public string GarageName { get; set; }*/
    }
}
