using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetOO3
{
    internal class Person
    {

        public int age { get; set; }
        public string fName { get; set; }
        public string lName { get; set; }
        public int? height { get; set; }
        public int? weight { get; set; }



        public int Age
        {
            get { return age; }

            set
            {
                try
                {
                    if (age < 0)
                    {
                        age = 0;
                    }
                    else
                    {
                        age = value;
                    }
                }
                catch (Exception exeption)
                {
                    Console.WriteLine("The input of the last age failed");
                }
            }
        }

        public string Fname
        {
            get { return fName; }

            set 
            { 
                try
                {
                    if (value.Length >= 2 && value.Length <= 10) fName = value;
                    else Console.WriteLine("The first name neds to be between 2 and 10 chars");
                }
                catch (Exception exeption)
                {
                    Console.WriteLine("The input of the first name failed");
                }
            }
        }

        public string LName
        {
            get { return lName; }
            
            set 
            {
                try
                {
                    if (value.Length >= 3 && value.Length <= 15) lName = value;
                    else Console.WriteLine("The last name neds to be between 2 and 10 chars");
                    
                }
                catch (Exception exeption)
                {
                    Console.WriteLine("The input of the last name failed");
                }
            }
        }

        public int? Height
        {
            get { return height; }
            set
            {
                try
                {
                    height = value;
                }
                catch (Exception exeption)
                {
                    Console.WriteLine("The input of the last name weight");
                }
            }
        }

        public int? Weight 
        { 
            get { return weight; }
            set 
            {
                try
                {
                    weight = value;
                }
                catch (Exception exeption)
                {
                    Console.WriteLine("The input of the last name weight");
                }
            }
        }

        public Person(int years, string firstName, string seconName, int heightII, int weightII)
        {
            age = years;
            fName = firstName;
            lName = seconName;
            height = heightII;
            weight = weightII;
        }
      
    }
}
