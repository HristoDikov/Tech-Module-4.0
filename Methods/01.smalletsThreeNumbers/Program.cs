using System;

namespace _01.smalletsThreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            GettheSmallestInteger(a,b,c);
        }

        private static void GettheSmallestInteger(int a, int b, int c)
        {
            if (a > b && b < c)
            {
                Console.WriteLine(b);
            }
            else if (b > a && a < c)
            {
                Console.WriteLine(a);
            }
            else if (a > c && c < b)
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(a);
            }
        }
    }
}
