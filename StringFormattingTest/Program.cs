using System;

namespace StringFormattingTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Formatting Test");


            int n = 99;

            string message = "The value is " + n;


            Console.WriteLine(message);


            Console.WriteLine("The value is {0}", n);


            int a = 10;
            int b = 20;

            int answer = a + b;

            Console.WriteLine("{0} + {1} = {2}", a, b, answer);

            message = String.Format("{0} + {1} = {2}", a, b, answer);

            Console.WriteLine(message);


            double price = 123.987654;
            price = 0.99;


            Console.WriteLine("The price is {0:0.00}", price);



            message = $"The price is { price }";

            Console.WriteLine(message);



            message = $"{ a } + { b } = { answer }";

            Console.WriteLine(message);


            message = $"{ a } + { b} = { a + b }";


            Console.WriteLine(message);


            Random rnd = new Random();



            message = $"The value is { rnd.Next(100) }";

            Console.WriteLine(message);


            int r = rnd.Next(100);


            message = $"The random number {r} is {(r > 50 ? "large" : "small")}";

            Console.WriteLine(message);



            string firstName = "Alice";
            string lastName = "Anderson";



            message = $"Person:\n{ firstName } { lastName }";

            Console.WriteLine(message);


            message = $"line1 \npress the \"red\" button";

            Console.WriteLine(message);


            message = $"C:\\Program Files\\Microsoft\\Visual Studio 2019";

            Console.WriteLine(message);



            message = @" This is a literal string";

            Console.WriteLine(message);


            message = @" this won't do anything with \n or \\ ";

            Console.WriteLine(message);


            message = @"Literal strings can 
span 
multiple
lines
which is useful in some scenarios";


            Console.WriteLine(message);


            string filename = @"C:\Program Files\Microsoft\Visual Studio 2019";

            Console.WriteLine(filename);



            message = $@"
multi line string
that contains substitutions like
{ filename }
and spans multiple lines
and constains expressions like { a } + { b } = { a + b }
";

            Console.WriteLine(message);

            message = "Short message";

            for (int i=0; i<message.Length; i++)
            {
                Console.WriteLine(message[i]);
            }

            message = "These are some words";


            string[] words = message.Split(" ");

            foreach(string word in words)
            {
                Console.WriteLine(word);
            }



















































































        }
    }
}
