using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetOO3
{
    internal class Bird : Animal
    {
        public bool doesFly = true;

        public Bird(int years, string firstName, int mass) : base(years, firstName, mass)
        {

        }
        
        public override void DoSound()
        {
            Console.WriteLine("twiit");
        }

        public override string Stats()
        {
            return ("Name: " + name + " Weight: " + weight.ToString() + " Age: " + age.ToString() + doesFly.ToString());
        }
    }
}
