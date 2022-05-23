using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetOO3
{
    internal class Dog : Animal
    {
        public bool isCute = true;

        public Dog(int years, string firstName, int mass) : base(years, firstName, mass)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("woff");
        }

        public override string Stats()
        {
            return ("Name: " + name + " Weight: " + weight.ToString() + " Age: " + age.ToString() + isCute.ToString());
        }

        public string Fetch()
        {
            return ("Good doggy!");
        }

    }
}
