using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceTest
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public virtual void Display()
        {
            Console.WriteLine("Person:");
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}
