using System;

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

            Trainer t = new Trainer("Eve", "Evans", "E32323");
            t.Teach();

            Tutor tu = new Tutor("Fred", "Flintstone", "CPL");
            tu.Teach();


            ITeacher[] teachers =
            {
                new Trainer("Eve", "Evans", "E32323"),
                new Tutor("Fred", "Flintstone", "CPL")
            };

            Console.WriteLine("=================================");

            foreach (ITeacher teacher in teachers)
            {
                ((Person)teacher).Display();
                teacher.Teach();
            }





































        }
    }
}
