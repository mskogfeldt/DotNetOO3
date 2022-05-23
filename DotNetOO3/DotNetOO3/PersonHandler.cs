using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetOO3
{
    internal class PersonHandler
    {

        public void SetAge(Person pers, int age)
        {
            pers.Age = age;
        }

        public Person CreatePerson(int age, string fname, string lname, int height, int weight)
        {
            return new Person(age, fname, lname, height, weight);
        }

        public void HaveBirthday(Person pers)
        {
            Console.WriteLine("Hurray!");
            pers.Age ++;
        }
    }
}
