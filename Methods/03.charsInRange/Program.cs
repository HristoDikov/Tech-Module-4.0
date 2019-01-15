using System;

namespace _03.charsInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            GetRange(a, b);
        }

        private static void GetRange(char a, char b)
        {
            if (b > a)
            {
                for (int i = a; i < b - 1; i++)
                {
                    char charToPrint = (char)(i + 1);
                    Console.Write(charToPrint + " ");
                }
            }
            else
            {
                for (int i = b; i < a - 1; i++)
                {
                    char charToPrint = (char)(i + 1);
                    Console.Write(charToPrint + " ");
                }
            }
           
        }
    }
}
