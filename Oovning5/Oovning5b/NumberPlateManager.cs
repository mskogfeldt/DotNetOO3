using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oovning5b
{
    internal class NumberPlateManager
    {
        public Dictionary<string, Vehicle> numberPlates = new Dictionary<string, Vehicle>();

        public void AddNewNumberPlate(string newPlate, Vehicle sweetRide)
        {
            if(IsNumberOfCorrectLength(newPlate) && IsPlateSyntaxOk(newPlate))
            {
                if (numberPlates.ContainsKey(newPlate))
                {
                    Console.WriteLine("This Vehicle is already registered");
                    //get me somewhere
                }
                else numberPlates.Add(newPlate, sweetRide);
            }
        }

        public bool IsNumberOfCorrectLength(string licenceNumber)
        {
            if (licenceNumber.Length != 6) return false;
            return true;
            
        }

        public bool IsPlateSyntaxOk(string number)
        {
            int count = 0;
            for (int i = 0; i < number.Length; i++)
            {
                if (i <= 2 && Char.IsNumber(number[i])) count++;
                else if(i > 2 && Char.IsLetter(number[i])) count++;
            }
            if (count == number.Length) return true;
            return false;
        }

       /* public Car CreateCar(string licenseNumber, string color, int weels, int doors)
        {
            Car newCar  
        }*/

       
    }
}
