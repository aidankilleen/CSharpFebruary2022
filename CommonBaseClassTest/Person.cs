using System;
using System.Collections.Generic;
using System.Text;

namespace CommonBaseClassTest
{
    class Person : Object
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
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return "Person:" + FirstName + " " + LastName;
        }

        public override bool Equals(object obj)
        {
            // Console.WriteLine("Person.Equals called");
            if ((obj == null || !this.GetType().Equals(obj.GetType())))
            {
                return false;
            }

            Person p = (Person)obj;

            if (p.FirstName.Equals(FirstName) && p.LastName.Equals(LastName)) {
                return true;
            } else
            {
                return false;
            }

        }
    }
}
