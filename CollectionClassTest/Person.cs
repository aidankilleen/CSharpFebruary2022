using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionClassTest
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

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   FirstName == person.FirstName &&
                   LastName == person.LastName;
        }

        public override string ToString()
        {
            return $"{ FirstName } { LastName }";
        }

        public void Display()
        {
            Console.WriteLine(ToString());
        }


        static void Main(string[] args)
        {


            //Program.personDictionary.
        }
    }
}
