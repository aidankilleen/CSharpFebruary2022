using System;

namespace OOTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OO Test");


            //Display()

            // code for testing the Card class


            
            int i = 1;
            string message = "hello";
            Card c = new Card();

            // create an instance of each card

            for (int s =1; s <=4; s++)
            {
                for (int v = 1; v <= 13; v++)
                {
                    c = new Card(s, v);
                    c.Display();
                }
                Console.WriteLine();
            }


            c = new Card(1, 12);

            c.Display();

            // c.value = 99;


            c.Display();


            Console.WriteLine();
            


        }
    }
}
