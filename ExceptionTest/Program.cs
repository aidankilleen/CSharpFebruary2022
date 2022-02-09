using System;

namespace ExceptionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exception Test");

            Random rnd = new Random();

            int x = 10;
            int y = 0;
            int answer;
            string s = null;

            int[] list = { 1, 2, 3, 4, 5 };

            try
            {
                switch (rnd.Next(5))
                {
                    case 0:
                        answer = x / y;
                        break;

                    case 1:
                        answer = list[5];
                        break;

                    case 2:
                        answer = s.Length;
                        break;

                    case 3:
                        throw new CustomException("Something went wrong");
                        

                    default:
                        answer = 42;
                        break;
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide By 0");
                answer = 0;
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range");
                answer = list[0];
            }
            catch (CustomException ex)
            {
                Console.WriteLine("The custom exception was thrown");
                answer = 100;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Some other exception occurred");
                Console.WriteLine(ex.Message);
                answer = 99;
            }
            finally
            {
                Console.WriteLine("This gets run no matter what!");
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
