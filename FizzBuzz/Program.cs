using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {







            for (int x = 1; x < 300; x++)

                if (x % 5 == 0 && x % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }

                else if (x % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (x % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }

        }
    }
}
