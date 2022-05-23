using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetOO3
{
    abstract internal class Animal
    {
        public string name { get; set; }
        public int weight { get; set; }
        public int age { get; set; }

       
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

        public string Name
        {
            get { return Name; }

            set
            {
                try
                {
                    if (value.Length >= 2 && value.Length <= 10) Name = value;
                    else Console.WriteLine("The first name neds to be between 2 and 10 chars");
                }
                catch (Exception exeption)
                {
                    Console.WriteLine("The input of the first name failed");
                }
            }
        }

        
        public int Weight
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

        public Animal(int years, string firstName, int mass)
        {
            age = years;
            name = firstName;
            weight = mass;
        }
        
        abstract public void DoSound();

    }


}
