using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oovning5b
{
    internal class Car : Vehicle
    {
        public int Doors;


        public Car(string color, int wheels, string garageName)
        {
            this.Color = color;
            this.Wheels = wheels;
            this.GarageName = garageName;
        }
      /*  public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public int Wheels { get; set; }
        public string GarageName { get; set; }*/
    }
}
