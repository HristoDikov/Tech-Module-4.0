using System;

namespace _05.addAndSubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int result = 0;
            int sum = SumIntegers(a, b);
            Substract(sum, c);
        }

        private static void Substract(int result, int c)
        {
            int substract = result - c;
            Console.WriteLine(substract);
        }

        private static int SumIntegers(int a, int b)
        {
            int result = a + b;
            return result;
        }
    }
}
