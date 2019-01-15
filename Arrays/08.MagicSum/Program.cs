using System;
using System.Linq;

namespace _08.MagicSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int equalNum = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                int currNum = numbers[i];

                for (int j = i; j < numbers.Length - 1; j++)
                {
                    result = currNum + numbers[j + 1];

                    if (result == equalNum)
                    {
                        Console.Write(currNum + " ");
                        Console.WriteLine(numbers[j + 1]);
                    }
                }

                
            }

        }
    }
}
