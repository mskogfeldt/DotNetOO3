using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetOO3
{
    internal class Horse : Animal
    {
        public bool isFast = true;

        public Horse(int years, string firstName, int mass) : base(years, firstName, mass)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("gnaag");
        }

        public override string Stats()
        {
            return ("Name: " + name + " Weight: " + weight.ToString() + " Age: " + age.ToString() + isFast.ToString());
        }
    }
}
