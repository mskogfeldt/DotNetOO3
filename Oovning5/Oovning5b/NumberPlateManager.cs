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
        UserInterface userInterface = new UserInterface();


        public void AddNewNumberPlate(string newPlate, Vehicle sweetRide)
        {
            if (IsNumberOfCorrectLength(newPlate) && IsPlateSyntaxOk(newPlate))
            {
                if (numberPlates.ContainsKey(newPlate))
                {
                    Console.WriteLine("This Vehicle is already registered");
                    //get me somewhere
                }
                else numberPlates.Add(newPlate, sweetRide);
            }
        }

        public bool ThisIsNotDuplicateLicensNumber(string newPlate)
        {
            if (numberPlates.ContainsKey(newPlate))
            {
                return false;
            }
            return true;
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
                else if (i > 2 && Char.IsLetter(number[i])) count++;
            }
            if (count == number.Length) return true;
            return false;
        }

        public void VehicleRegistrationNumbers()
        {
            foreach (var vehicle in numberPlates) userInterface.Message(vehicle.Key);
        }

        public Car CreateCar()
        {
            bool correctLicensPlate = false;
            string registrationNumber = "";
            string color;
            string wheels;
            string doors;
            while (correctLicensPlate == false)
            {
                string addName = "Please Enter the registration number";
                userInterface.Message(addName);
                string licensePlate = userInterface.InputSomething("Registration Number");
                if (IsNumberOfCorrectLength(licensePlate) && IsPlateSyntaxOk(licensePlate) && ThisIsNotDuplicateLicensNumber(licensePlate))
                {
                    correctLicensPlate = true;
                }
                registrationNumber = licensePlate;
            }
            string addColor = "Please Enter the registration number";
            userInterface.Message(addColor);
            string carsColor = userInterface.InputSomething("Registration Number");

            string addWheels = "Please Enter the registration number";
            userInterface.Message(addWheels);
            int numberOfWheels = userInterface.InputNumber(addWheels);

            string addDoors = "Please enter the number of doors";
            int numberOfDoors = userInterface.InputNumber(addWheels);

            Car car = new Car(registrationNumber, carsColor, numberOfWheels, numberOfDoors);
            return car;
        }





    }
}
