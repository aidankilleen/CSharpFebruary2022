using System;

namespace DelegateTest
{
    class Program
    {

        static bool CheckIfEven(int n)
        {
            return n % 2 == 0;
        }
        static bool CheckIfOdd(int n)
        {
            return n % 2 == 1;
        }
        static void ProcessListForEven(int[] list)
        {
            foreach(int item in list)
            {
                if (CheckIfEven(item))
                {
                    Console.WriteLine($" {item }");
                }
            }
        }
        static void ProcessListForOdd(int[] list)
        {
            foreach (int item in list)
            {
                if (CheckIfOdd(item))
                {
                    Console.WriteLine($" { item }");
                }
            }
        }

        delegate bool CheckFunction(int n);


        static void ProcessList(int[] list, CheckFunction checkFunction)
        {
            foreach (int item in list)
            {
                if (checkFunction(item))
                {
                    Console.WriteLine($" { item }");
                }
            }
        }

        static int Add(int a, int b)
        {
            return a + b;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Delegate Test");

            int[] list = { 1, 2, 1, 5, 6, 8, 5, 4, 9, 10, 3 };

            ProcessList(list, CheckIfEven);

            Console.WriteLine("====================");

            ProcessList(list, CheckIfOdd);

            // ProcessList(list, Add);  // type safety on my method parameter
        }
    }
}
