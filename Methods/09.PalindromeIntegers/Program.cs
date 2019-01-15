using System;
using System.Text;

namespace _09.PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (true)
            {
                if (input == "END")
                {
                    break;
                }
                
                FindPalindrome(input);

                input = Console.ReadLine();
            }
        }

        private static void FindPalindrome(string input)
        {
            StringBuilder reversedInput = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                reversedInput.Append(input[input.Length - 1 - i].ToString());

            }
            string revInput = reversedInput.ToString();
            if (revInput == input)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}
