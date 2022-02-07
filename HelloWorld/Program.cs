using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {

            /* 
             * C# supports c-style comments 
             */

            Console.WriteLine("Hello World!"); // C# supports c++ style comments 


            // Variables
            // variables must be declared
            // variable must be given a type (either explictly or implicitly)
            int i;


            // Console.WriteLine(i); // no unassigned variable in C#

            string name;
            int v = 99;
            string message = "hello";


            //message = 99;

            int a = 100;
            int b = 10;

            // int answer = a / b;


            Console.WriteLine(message.Length);


            //  Expressions

            int answer = a / b;

            message = "The answer is " + answer;

            Console.WriteLine(message);

            Console.WriteLine("The answer is " + answer);


            //  Conditions

            int n = 50;

            if (n == 50)  // must evaluate to a boolean   
            {
                Console.WriteLine("n is = 50");
            }
            else if (n > 50)
            {
                Console.WriteLine("n is > 50");
            }
            else
            {
                Console.WriteLine("n is not equal to 50");
            }


            // Condition #2
            switch(n)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                default:
                    Console.WriteLine("something else");
                    break;
            }

            // Condition #3 - Ternary operator

            int value = 100;

            string msg = "the value is " + (value > 50 ? "Big" : "Small");

            if (value > 50)
            {
                msg = "the value is Big";
            } else
            {
                msg = "the value is Small";
            }




            // Loops 
            int count = 0;
            while (count < 10)
            {
                Console.WriteLine(count);
                count++;  // count = count + 1
            }

            // Loop # 2 
            for (int c = 0; c < 10; c++)
            {
                Console.WriteLine(c);
            }



            // List or Array
            int[] list = { 1, 3, 5, 2, 4, 1, 8, 9 };


            // arrays are fixed length - but there are Collection Classes which are variable in length

            Console.WriteLine(list[0]);
            Console.WriteLine(list[5]);
            //Console.WriteLine(list[99]);  bounds checking by default


            for (i=0; i<list.Length; i++)
            {
                Console.WriteLine(i + " " + list[i]);
            }


            foreach (int item in list)
            {
                Console.WriteLine(item);
            }


            // Functions
            answer = TestFunction(100, 200);
            Console.WriteLine(answer);


            // Objects




        }
        public static int TestFunction(int a, int b)
        {
            return a + b;
        }

        public static void ShowMessage(string message)
        {
            Console.WriteLine(message);
        }



    }
}
