using System;

namespace _2nd
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal input = decimal.Parse(Console.ReadLine());
            decimal divider = 0;

            if (input % 2 == 0)
            {
                divider = 2;
            }
            if (input % 3 == 0)
            {
                divider = 3;
            }
            if (input % 6 == 0)
            {
                divider = 6;
            }
            if (input % 7 == 0)
            {
                divider = 7;
            }
            if (input % 10 == 0)
            {
                divider = 10;
            }

            if (divider == 0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {divider}");
            }

        }
    }
}
