using System;

namespace _01.Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int[] nums = new int[count];
            int sum = 0;

            for (int i = 0; i < count; i++)
            {

                int num = int.Parse(Console.ReadLine());
                nums[i] = num;
            }

            for (int i = 0; i < count; i++)
            {
                sum += nums[i];
            }
            Console.WriteLine(string.Join(" ", nums));
            Console.WriteLine(sum);
        }
    }
}
