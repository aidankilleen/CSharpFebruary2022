using System;

namespace StaticTest
{
    class Program
    {

        static int TestFunction(int a, int b)
        {
            return a + b;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Static Test");
            int answer = TestFunction(100, 200);

            Console.WriteLine($"The answer is { answer }");
            Console.WriteLine(Message.count);

            Message msg1 = new Message("Message 1", "This is Message 1");
            Console.WriteLine(Message.count);
            //Console.WriteLine(msg1.count); // can't access using an instance

            Message msg2 = new Message("Message 2", "This is Message 2");
            Console.WriteLine(Message.count);

            Message msg3 = new Message("Message 3", "This is Message 3");
            Console.WriteLine(Message.count);

            Message.Info();


            Console.WriteLine(Math.PI);

            String s = "this is a string";


            string ns = "1234";

            int n = int.Parse(ns);


            Console.WriteLine(n);


            double d = double.Parse("1.234");


            DateTime now = DateTime.Now;

            Console.WriteLine(now);


            Console.WriteLine("Pausing...");


            



































            


        }
    }
}
