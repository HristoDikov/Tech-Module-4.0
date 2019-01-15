using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int[] bombNumPower = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray();

            int bombNum = bombNumPower[0];
            int bombPower = bombNumPower[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                int currNum = numbers[i];
                if (currNum == bombNum)
                {

                    int leftRange = i - bombPower;
                    int removingCount = bombPower + i;

                    if (leftRange < 0)
                    {
                        leftRange = 0;
                    }
                    if (removingCount > numbers.Count - 1)
                    {
                        removingCount = numbers.Count - 1;
                    }
                    if (leftRange > numbers.Count - 1)
                    {
                        continue;
                    }
                    if (removingCount < 0)
                    {
                        continue;
                    }

                    numbers.RemoveRange(leftRange, removingCount - leftRange + 1);
                    i = leftRange - 1;
                }
            }
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
