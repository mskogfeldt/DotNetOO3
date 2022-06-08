using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oovning5b
{
    internal class Garage<T> //:IEnumerable<T> where T : class
    {
        //public  Enumerator  GetEnumerator();
        private Vehicle[] parkedVehicles;

        public Garage(int numberOfSpots)
        {
            this.parkedVehicles = new Vehicle[numberOfSpots];
        }

       
    }
}
