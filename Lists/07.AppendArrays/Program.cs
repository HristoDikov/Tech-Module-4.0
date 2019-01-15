using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<string> result = new List<string>();

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                string[] array = numbers[i]
                    .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int j = 0; j < array.Length; j++)
                {
                    result.Add(array[j]);
                }
            }
            Console.WriteLine(string.Join(" ", result));

        }
    }
}
