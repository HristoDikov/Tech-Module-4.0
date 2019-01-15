using System;
using System.Collections.Generic;

namespace _01.CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            var chars = new Dictionary<char, int>();

            char[] input = Console.ReadLine()
                .ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ' ')
                {
                    continue;
                }
                if (chars.ContainsKey(input[i]))
                {
                    chars[input[i]]++;
                }
                if (!chars.ContainsKey(input[i]))
                {
                    chars.Add(input[i], 1);
                }
                
                
            }
            
            foreach (var c in chars)
            {
                Console.WriteLine(c.Key + " " + "->" + " " + c.Value);
            }
        }
    }
}
