using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> topIntegers = new List<int>();

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int comparator = numbers[i];

                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (comparator > numbers[i + j + 1])
                    {
                        if (!topIntegers.Contains(comparator))
                        {
                            topIntegers.Add(comparator);
                            continue;
                        }

                    }
                    else
                    {
                        if (topIntegers.Contains(comparator))
                        {
                            topIntegers.Remove(comparator);
                        }
                    }
                }
            }
            topIntegers.Add(numbers[numbers.Length - 1]);
            Console.WriteLine(string.Join(" ", topIntegers));


        }
    }
}
