using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetOO3
{
    
    
    internal class Flamingo : Bird
    {

        public bool isPink = true;

        public Flamingo(int years, string firstName, int mass) : base(years, firstName, mass)
        {

        }

        public override string Stats()
        {
            return ("Name: " + name + " Weight: " + weight.ToString() + " Age: " + age.ToString() + isPink.ToString());
        }
    }
}
