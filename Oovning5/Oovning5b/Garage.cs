using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oovning5b
{
    internal class Garage/*<T>*///:IEnumerable<T> where T : class
    {
        //public  Enumerator  GetEnumerator();
        string name;
        private Vehicle[] parkedVehicles;

        public Garage(int numberOfSpots, string name)
        {
            this.parkedVehicles = new Vehicle[numberOfSpots];
            this.name = name;
        }

       
    }
}
