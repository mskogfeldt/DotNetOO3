using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetOO3
{
    internal class Wolf : Animal
    {
        public bool isScary = true;

        public Wolf(int years, string firstName, int mass) : base(years, firstName, mass)
        {

        }

        public override void DoSound()
        {
            Console.WriteLine("WOOOOOOOOO!");
        }

        public override string Stats()
        {
            return ("Name: " + name + " Weight: " + weight.ToString() + " Age: " + age.ToString() + isScary.ToString());
        }
    }
}
