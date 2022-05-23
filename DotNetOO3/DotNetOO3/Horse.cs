using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetOO3
{
    internal class Horse : Animal
    {
        public bool isfast = true;

        public Horse(int years, string firstName, int mass) : base(years, firstName, mass)
        {
        }

        public override void DoSound()
        {
            Console.WriteLine("gnaag");
        }
    }
}
