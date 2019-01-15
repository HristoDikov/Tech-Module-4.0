using System;
using System.Linq;

namespace _04.CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string result = "";

            for (int i = 0; i < input.Length; i++)
            {
                char currChar = input[i];

                int charInt = currChar + 3;
                currChar = (char)charInt;
                result += currChar;
            }

            Console.WriteLine(result);
        }
    }
}
