using System;

namespace OOConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OO Concepts");

            // Abstraction
            // the ability to create an Object 
            // Object has data & methods


            // Encapsulation
            // ability to protect our data / methods
            // using the public and private keywords
            // and properties with get and set methods for validation

            //Card c = new Card(Suits.Heart, Values.Three);


            //c.Suit = 99;



            //c.Display();

            //for (int s = 1; s<=4; s++)

            foreach(Suits s in Enum.GetValues(typeof (Suits)))
            {
                foreach(Values v in Enum.GetValues(typeof(Values)))
                {
                    Card c2 = new Card(s, v);

                    c2.Display();

                }
                Console.WriteLine();
            }


            Card c3 = new Card();
            c3.Display();

            Card c4 = new Card(value: Values.King, suit: Suits.Club);
            c4.Display();

            Card c5 = new Card(value: Values.Ten);
            c5.Display();











            // Inheritance


            // Polymorphism



        }
    }
}
