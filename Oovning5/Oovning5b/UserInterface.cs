using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oovning5b
{
    internal class UserInterface
    {

        public void PrintGreeting()
        {
            Console.WriteLine("Wellcome to the Garage Inc admin system!");
        }
        //1
        public void PrintMainMenu()
        {
            Console.WriteLine("Press 1 to search Garage: ");
            Console.WriteLine("Press 2 to search for Vehicle");
            // Console.WriteLine("Press 3 to add a new Garage: ");
            //Console.WriteLine("Press 4 to add a new Vehicle: ");
            Console.WriteLine("Press 0 to quit the app: ");
        }

       
        //2a
        public void PrintManageGarageMenu()
        {
            Console.WriteLine("Press 1 to add a new Garage: ");
            Console.WriteLine("Press 2 to admin a Garage: ");
            Console.WriteLine("Press 0 to go to main menu: ");
        }

        //2b
        public void PrintManageVehicleMenu()
        {
            Console.WriteLine("Press 1 to add a new Vehicle: ");
            Console.WriteLine("Press 2 to admin a Vehicle: ");
            Console.WriteLine("Press 0 to go to main menu: ");
        }

        //2a1a
        public void PrintAddGarageNumberOfSpaces()
        {
            Console.WriteLine("Pleas Enter the numbber of spaces in this new bulding");
            Console.WriteLine("Press 0 to go to Manage Garage");
        }

        //2a1b
        public void PrintAddGarageName()
        {
            Console.WriteLine("Please Enter the name for this new bulding");
            Console.WriteLine("Press 0 to go to Manage Garage");
        }

        //2b2a 
        public void PrintAddVehicleType()
        {
            Console.WriteLine("To add a Airplane Press 1");
            Console.WriteLine("To add a Boat Press 2");
            Console.WriteLine("To add a bus Press 3");
            Console.WriteLine("To add a Car Press 4");
            Console.WriteLine("To add a Motorcycle Press 5");
            Console.WriteLine("Press 0 to go to Manage Vehicle");
        }


        


        /*Console.WriteLine("Press 1 to park a Vehicle: ");
            Console.WriteLine("Press 2 to unpark a Vehicle: ");*/
        // 1 PrintMainMenu
        public int InputfromMenu(List<int> possibleChoices)
        {
            bool keepTyping = true;
            int returnvalue = 0;
            while (keepTyping)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number of your choice");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some valid input!");
                }
                if (Char.IsNumber(input) && possibleChoices.Contains(input))
                {
                    return input;
                }
            }
            return -1;
        }

   /*     PrintAdminGarageMenu
            PrintAdinVehicleMenu
            PrintAddGarageNumberOfSpaces*/

            //
        public int InputNumberOfSpacesInNewGarage()
        {
            Console.WriteLine("Enter how many spaces there are in the new Garage");
            string spacees = Console.ReadLine();
            if (IsItAnInt(spacees))
            {
                return Int32.Parse(spacees);
            }
            else return -1;
        }

        public string InputName(string argument)
        {
            bool keepTyping = true;
            string name = "";
            while (keepTyping)
            {
                Console.WriteLine("Enter " + argument + " . At Least to chars long");
                Console.WriteLine("Enter 0 to go back");
                name = Console.ReadLine();
                if (name.Length > 1 || name == "0") keepTyping = false;
            }
            return name;
        }

        public bool IsItAnInt(string numberToBe)
        {
            try
            {
                int result = Int32.Parse(numberToBe);
                return true;
            }
            catch (FormatException)
            {
                return false;
            }
            return false;
        }

        public void Message(string message)
        {
            Console.WriteLine(message);
        }

        public void Sucess(string message)
        {
            Console.WriteLine("Sucess" + message);
        }

        
    }
}
