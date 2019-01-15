using System;

namespace _03.Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string[] firstArr = new string[count];
            string[] secondArr = new string[count];

            for (int i = 0; i < count; i++)
            {
                string[] textTwo = Console.ReadLine().Split();
                string firstNum = textTwo[0];
                string secNum = textTwo[1];


                if (i % 2 == 0)
                {
                    firstArr[i] = firstNum;
                    secondArr[i] = secNum;
                }
                else
                {
                    firstArr[i] = secNum;
                    secondArr[i] = firstNum;
                }
            }
            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}
