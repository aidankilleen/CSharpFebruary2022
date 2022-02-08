﻿using System;

namespace InheritanceTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inheritance Test");

            Person p = new Person("Alice", "Andrews");
            p.Display();

            Employee e = new Employee("Bob", "Burton", "E12345");
            e.Display();

            Contractor c = new Contractor("Carol", "Connors", "CPL");
            c.Display();

            Manager m = new Manager("Danielle", "Dorgan", "E54321", 8);
            m.Display();


            // Polymophism


            Console.WriteLine("=========================================");
            Person[] people = {

                new Person("Alice", "Andrews"),
                new Employee("Bob", "Burton", "E12345"),
                new Contractor("Carol", "Connors", "CPL"),
                new Manager("Danielle", "Dorgan", "E54321", 8)
            };


            foreach (Person person in people)
            {
                person.Display();
            }


























        }
    }
}
