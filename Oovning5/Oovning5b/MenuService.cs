using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oovning5b
{
    internal class MenuService
    {
        Oovning5b.UserInterface userInterface = new UserInterface();
        Oovning5b.GarageService garageService = new GarageService();
        Oovning5b.NumberPlateManager numberPlateManager = new NumberPlateManager();


        public void MainMenu()
        {
            //bool keepWorkin = true;
            List<int> menuChoises = new List<int>() { 0, 1, 2 };
            userInterface.PrintMainMenu();
            int input = userInterface.InputfromMenu(menuChoises);
            if (input == 0) System.Environment.Exit(1);
            else if (input == 1) ManageGarageMenu();
            else if (input == 2) ManageVehicleMenu();
            else MainMenu();

        }

        public void ManageGarageMenu()
        {
            //bool keepWorkin = true;
            List<int> menuChoises = new List<int>() { 0, 1, 2 };
            userInterface.PrintManageGarageMenu();
            int input = userInterface.InputfromMenu(menuChoises);
            if (input == 0) MainMenu();
            else if (input == 1) AddGarageMenu();
            else if (input == 2) ParkVehicleMenu();
            else ManageGarageMenu();
        }

        public void ManageVehicleMenu()
        {
            //bool keepWorkin = true;
            List<int> menuChoises = new List<int>() { 0, 1, 2, 3 };
            userInterface.PrintManageVehicleMenu();
            int input = userInterface.InputfromMenu(menuChoises);
            if (input == 0) MainMenu();
            else if (input == 1) AddVehicleTypeMenu();
            else if (input == 2) ParkVehicleMenu();
            else if (input == 3) UnparkVhicleMenu();
            else ManageVehicleMenu();
        }

        public void AddGarageMenu()
        {
            List<int> menuChoises = new List<int>() { 0, 1, 2 };
            //userInterface.PrintAddGarageName();
            string instructions = "Please input the new garages name";
            string garageName = userInterface.InputSomething(instructions);
            int numberOfParkingSlots;

            if (garageName == "0") ManageGarageMenu();
            else
            {
                numberOfParkingSlots = userInterface.InputNumber("Please enget the number of parkingslots this fine esatblishment has to offer:");
                var garage = new Garage<Vehicle>(numberOfParkingSlots, garageName);
                try
                {
                    garageService.garages.Add(garageName, garage);
                    userInterface.Message(garage.Name + " added");
                }
                catch
                {
                    userInterface.Message("Your skilled coWorkers har already added said garage");
                }
            }
            MainMenu();
        }

        public void AddVehicleTypeMenu()
        {
            userInterface.PrintAddVehicleType();
            List<int> possibleSellections = new List<int>() { 0, 1, 2, 3, 4, 5 };
            int menuSelection = userInterface.InputfromMenu(possibleSellections);
            string optionQuestionmark = "What are you nuts, just buy a car instead, youll get a car";
            if (menuSelection == 0) ManageVehicleMenu();
            else if (menuSelection == 1) 
            {
                userInterface.Message(optionQuestionmark);
                numberPlateManager.CreateCar();
            } 
            else if (menuSelection == 2)
            {
                userInterface.Message(optionQuestionmark);
                numberPlateManager.CreateCar();
            }
            else if (menuSelection == 3)
            {
                userInterface.Message(optionQuestionmark);
                numberPlateManager.CreateCar();
            }
            else if (menuSelection == 4) numberPlateManager.CreateCar();
            else if (menuSelection == 5)
            {
                userInterface.Message(optionQuestionmark);
                numberPlateManager.CreateCar();
            }
        }

        public void UnparkVhicleMenu()
        {
            Vehicle vehicle = SearchVehicleMenu();
            garageService.UnParkVehicle(vehicle);
        }

        public void ParkVehicleMenu()
        {
            Vehicle vehicle = SearchVehicleMenu();
            var garage = SearchGarageMenu();
            garageService.ParkVehicle(vehicle, garage);
        }

        public Vehicle SearchVehicleMenu()
        {
            bool keepTypingRegestrationNumber = true;
            while (keepTypingRegestrationNumber)
            {
                string instructionsRegNr = "Please enter registration number";
                string renNr = userInterface.InputSomething(instructionsRegNr);
                if (numberPlateManager.numberPlates.ContainsKey(renNr))
                {
                    Vehicle vehicle = numberPlateManager.numberPlates[renNr];
                    string vehicleFound = vehicle.RegistrationNumber + " is found";
                }
            }
            return null;
        }

        public Garage<Vehicle> SearchGarageMenu()
        {
            bool keepTypingGarageName = true;
            while (keepTypingGarageName)
            {
                string instructionsGarageName = "Please enter the garage name";
                string garageName = userInterface.InputSomething(instructionsGarageName);
                if (garageService.garages.ContainsKey(garageName))
                {
                    var garage = garageService.garages[garageName];
                    string garageFound = garage.Name + " is found";
                    return garage;
                }
            }
            return null;
        }

        
        
    }
}
/*
 class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParanthesis"
                    + "\n5. Fibonacci ala recursive"
                    + "\n6. Fibonacci ala itterative"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '0':
                        Environment.Exit(0);
break;
default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
{
    // Loop this method untill the user inputs something to exit to main menue.
    bool keepLooping = true;
    List<string> theList = new List<string>();
    while (keepLooping)
    {
        Console.WriteLine("Please navigate through the menu by inputting a character \n(+, -, 0 ,1) of your choice"
            + "\n+. Add string to List"
            + "\n-. Remove ´first item from List"
            + "\n0. Back to main menu");
        char input = ' '; //Creates the character input to be used with the switch-case below.
        try
        {
            input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
        }
        catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
        {
            Console.Clear();
            Console.WriteLine("Please enter some input!");
        }
        switch (input)
        {


            case '+':
                Console.WriteLine("Before adding the string, the capacity of the list is: " + CheckList(theList));
                Console.WriteLine("List count is. " + theList.Count());
                Console.WriteLine("Please type in string for Da List");
                theList.Add(UserInput());
                Console.WriteLine("After adding the string, the capacity of the list is: " + CheckList(theList));
                Console.WriteLine("List count is. " + theList.Count());
                break;
            case '-':

                Console.WriteLine("removing the first string of the list");
                try
                {
                    Console.WriteLine("Before removing the string, the capacity of the list is: " + CheckList(theList));
                    Console.WriteLine("List count is. " + theList.Count());
                    theList.RemoveAt(0); //Tries to set input to the first char in an input line
                    Console.WriteLine("After removing the string, the capacity of the list is: " + CheckList(theList));
                    Console.WriteLine("List count is. " + theList.Count());
                }
                catch (ArgumentOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("The list seems to be empty, please enter a string to the list");
                    ExamineList();
                }
                break;
            case '0':
                Main();
                break;
            default:
                Console.WriteLine("Please enter some valid input (+, -, 0)");
                break;
        }

    }
   
}


static void ExamineQueue()
{
    Queue<string> theQueue = new Queue<string>();
    bool keepLooping = true;

    while (keepLooping)
    {
        Console.WriteLine("Please navigate through the menu by inputting a character \n(+, -, 0 ,1) of your choice"
            + "\n+. Add customer to Hemmköp Cue"
            + "\n-. Remove customer from Hemmköp cue"
            + "\n0. Back to main menu");
        char input = ' '; //Creates the character input to be used with the switch-case below.
        try
        {
            input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
        }
        catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
        {
            Console.Clear();
            Console.WriteLine("Please enter some input!");
        }
        switch (input)
        {
            case '+':
                Console.WriteLine("Before adding the customer, the Queue looks like this ");
                PrintTheCue(theQueue);
                Console.WriteLine("The Queue has: " + theQueue.Count + " humans in it");
                Console.WriteLine("enter the customers name.");
                theQueue.Enqueue(UserInput());

                Console.WriteLine("After adding the customer, the Queue looks like this ");
                PrintTheCue(theQueue);
                Console.WriteLine("The Queue has: " + theQueue.Count + " humans in it");
                break;

            case '-':
                Console.WriteLine("removing the first string of the list");
                try
                {
                    Console.WriteLine("Before removing the customer, the Queue looks like this ");
                    PrintTheCue(theQueue);
                    Console.WriteLine("The Queue has: " + theQueue.Count + " humans in it");
                    theQueue.Dequeue();
                    Console.WriteLine("After removing the customer, the Queue looks like this ");
                    PrintTheCue(theQueue);
                    Console.WriteLine("The Queue has: " + theQueue.Count + " humans in it");
                }
                catch (ArgumentOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("The list seems to be empty, please enter a string to the list");
                    ExamineList();
                }
                break;
            case '0':
                Main();
                break;
            default:
                Console.WriteLine("Please enter some valid input (+, -, 0)");
                break;
        }
    }
}

/// <summary>
/// Examines the datastructure Stack
/// </summary>
static void ExamineStack()
{

    // Loop this method until the user inputs something to exit to main menue.
    Stack<string> theStack = new Stack<string>();

    bool keepLooping = true;

    while (keepLooping)
    {
        Console.WriteLine("Please navigate through the menu by inputting a character \n(+, -, 0 ,1) of your choice"
            + "\n+. Add customer to Ica Queue"
            + "\n-. Remove customer from Ica Queue"
            + "\n0. Back to main menu");
        char input = ' '; //Creates the character input to be used with the switch-case below.
        try
        {
            input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
        }
        catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
        {
            Console.Clear();
            Console.WriteLine("Please enter some input!");
        }
        switch (input)
        {
            case '+':
                Console.WriteLine("Before adding the customer, the Queue looks like this ");
                // PrintTheCue(theStack);
                Console.WriteLine("The Queue has: " + theStack.Count + " humans in it");
                Console.WriteLine("enter the customers name.");
                theStack.Push(UserInput());

                Console.WriteLine("After adding the customer, the Queue looks like this ");
                //PrintTheCue(theStack);
                Console.WriteLine("The Queue has: " + theStack.Count + " humans in it");
                break;

            case '-':
                Console.WriteLine("removing the first string of the list");
                try
                {
                    Console.WriteLine("Before removing the customer, the Queue looks like this ");
                    // PrintTheCue(theStack);
                    Console.WriteLine("The Queue has: " + theStack.Count + " humans in it");
                    theStack.Pop();
                    Console.WriteLine("After removing the customer, the Queue looks like this ");
                    //PrintTheCue(theStack);
                    Console.WriteLine("The Queue has: " + theStack.Count + " humans in it");
                }
                catch (ArgumentOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("The list seems to be empty, please enter a string to the list");
                    ExamineList();
                }
                break;
            case '0':
                Main();
                break;
            default:
                Console.WriteLine("Please enter some valid input (+, -, 0)");
                break;

               
    }

    


    */