using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetOO3
{
    internal class Wolfman : Wolf, IPerson //class USBDevice : GenericDevice, IOurDevice

    {
        public Wolfman(int years, string firstName, int mass) : base(years, firstName, mass)
        {

            
        }
        //public virtual string Stats()
        public override string Stats()
        {
            return ("Name: " + name + " Weight: " + weight.ToString() + " Age: " + age.ToString() + isScary.ToString());
        }

        public void Talk()
        {
            Console.WriteLine("https://www.youtube.com/watch?v=BEHfirKjBzo" + " is good advice for a teenwolf");
        }


    }
}