using System;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exception Test");


            string s = null;


            Console.WriteLine(s.ToUpper());





            int[] list = { 1, 2, 3, 4, 5 };
            Console.WriteLine(list[list.Length]);








            int x = 100;
            int y = 0;

            int answer;
            
            try
            {
                answer = x / y;

            } catch (DivideByZeroException ex)
            {
                Console.WriteLine("You can't divide by zero!");
                answer = 0;
            }


            Console.WriteLine($"The answer is { answer }");
            Console.WriteLine("Finished");








            /*
             * Exception Handling
             * 
             * (Glass is half full approach)
             * 
            int x = 100;
            int y = 0;

            try
            {
                DoSomething(x, y);
                DoSomethingElse();

            }
            catch (NetworkException ne)
            {
                // network error
            }
            catch(FileNotFound fne)
            {
                // file not found
            }
            catch(InvalidParams ip)
            {

            }
            catch (Exception ex)
            {
                // this code runs if something goes wrong.
            }

            */




            /*
             * Traditional C-style coding / defensive programming
             * (Glass is half empty approach)
             * 
            int x = 100;
            int y = 0;

            if (x >0 && y > 0)
            {
                int r = DoSomething(x, y);

                if (r == 0)
                {
                    // success
                } else if (r == -1)
                {
                    // network error
                } else if (r == -2)
                {
                    // file not found error
                } else if (r == -3)
                {
                    // some other error
                }
            } else
            {
                // invalid parameters
            }

            r = DoSomethingElse();

            if (r == 0)
            {
                // success
            }
            else if (r == -1)
            {
                // network error
            }
            else if (r == -2)
            {
                // file not found error
            }
            else if (r == -3)
            {
                // some other error
            }

            */





















        }
    }
}
