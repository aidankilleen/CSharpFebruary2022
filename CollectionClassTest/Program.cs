using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionClassTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Colleciton Classes Test");


            int[] list = { 1, 5, 3, 7, 2, 9, 10 };

            //int[] extendedList = int[list.Length + 1];


            //list.


            // System.Collections.ArrayList arList = new System.Collections.ArrayList();

            // or
            // add using System.Collections at the top

            ArrayList arList = new ArrayList();

            arList.Add(1);
            arList.Add(5);
            arList.Add(3);
            arList.Add(7);
            arList.Add(2);
            arList.Add(9);          
            arList.Add(10);

            foreach (int item in arList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("===================================");
            arList.Add(6);

            foreach (int item in arList)
            {
                Console.WriteLine(item);
            }


            Console.WriteLine("===================================");

            ArrayList people = new ArrayList();

            people.Add(new Person("Alice", "Anderson"));
            people.Add(new Person("Bob", "Bailey"));
            people.Add(new Person("Carol", "Conway"));
            people.Add(new Person("Danielle", "Dunne"));
            // people.Add(new string("This is not a person object"));


            foreach (Person person in people)
            {
                person.Display();
            }

            // problem : ArrayList doesn't have any type safety


            Console.WriteLine("===================================");
            List<Person> team = new List<Person>();


            team.Add(new Person("Alice", "Anderson"));
            team.Add(new Person("Bob", "Bailey"));
            team.Add(new Person("Carol", "Conway"));
            team.Add(new Person("Danielle", "Dunne"));
            // team.Add(new string("not a person object")); Generic List has type safety
            // we will use List<> from now on 


            foreach (Person member in team)
            {
                member.Display();
            }

            List<int> numberList = new List<int>();

            numberList.Add(1);
            numberList.Add(2);
            numberList.Add(3);

            //numberList.Add(new Person("", ""));


            int[] numbersArray = new int[50]; // hard coded length

            List<int> numbersList = new List<int>(); // preferrable as length not needed

            Console.WriteLine("===================================");

            Dictionary<int, Person> peopleDictionary = new Dictionary<int, Person>();

            peopleDictionary.Add(1, new Person("Alice", "Anderson"));
            peopleDictionary.Add(2, new Person("Bob", "Bailey"));
            peopleDictionary.Add(3, new Person("Carol", "Conway"));
            peopleDictionary.Add(4, new Person("Dan", "Daly"));


            Console.WriteLine(peopleDictionary[3]);


            // because we are using generics - we have type safety

            // peopleDictionary.Add("p123", "not a person");  this is invalid

            Console.WriteLine("===================================");

            Dictionary<string, Person> peopleDictionary2 = new Dictionary<string, Person>();


            peopleDictionary2.Add("AA", new Person("Alice", "Anderson"));
            peopleDictionary2.Add("BB", new Person("Bob", "Bailey"));
            peopleDictionary2.Add("CC", new Person("Carol", "Conway"));
            peopleDictionary2.Add("DD", new Person("Dan", "Daly"));


            Console.WriteLine(peopleDictionary2["CC"]);


            // peopleDictionary2.Add(5, new Person("Eve", "Evans"));



            

            foreach (string key in peopleDictionary2.Keys)
            {
                Console.WriteLine($"{ key } : { peopleDictionary2[key] }");

            }
































































        }
    }
}
