using System;

namespace TupleTest
{
    class Program
    {
        static Result ProcessList(int[] list)
        {
            Result r = new Result(0, 0.0);

            int total = 0;

            foreach (int item in list)
            {
                total += item;
            }
            double average = total / list.Length;
            r.Total = total;
            r.Average = average;
            return r;
        }


        static (int Total, double Average) ProcessList2(int[] list)
        {
            int total = 0;
            foreach(int item in list)
            {
                total += item;
            }
            double average = total / list.Length;

            return (total, average);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Tuple Test");

            int[] list = { 1, 4, 2, 3, 6, 5, 8, 9, 6, 2, 10, 6 };
            (int Total, double Average) answer = ProcessList2(list);
            Console.WriteLine($"The answer is { answer.Total }, { answer.Average } ");

            int a = 10;
            int b = 20;

            // swap a and b
            //int t = a;
            //a = b;
            //b = t;
            Console.WriteLine($"Before = {a} {b}");

            (a, b) = (b, a);

            Console.WriteLine($"After = {a} {b}");













        }
    }
}
