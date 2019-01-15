using System;
using System.Linq;

namespace _01._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            string charr = (Console.ReadLine());

            if (charr.Any(char.IsUpper))
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
