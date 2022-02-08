using System;

namespace CommonBaseClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Common Base Class");

            Person p = new Person("Alice", "Andrews");

            Console.WriteLine(p);

            Person p2 = new Person("Alice", "Andrews");
            //Person p2 = p;

            // never use == comparison
            // use .Equals instead!
            if (p.Equals(p2))
            {
                Console.WriteLine("The same");
            } else
            {
                Console.WriteLine("Different");
            }

        }
    }
}
