using System;

namespace _02.vowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            vowelsCount(text);
        }

        private static void vowelsCount(string text)
        {
            int vowels = 0;
            for (int i = 0; i < text.Length; i++)
            {
                string a = text[i].ToString();
                if (a == "a" || a == "e" || a == "i" || a == "o" || a == "u")
                {
                    vowels++;
                }
            }
            Console.WriteLine(vowels);
        }
    }
}
