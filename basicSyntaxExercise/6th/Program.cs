using System;
using System.Linq;

namespace _6th
{
    class Program
    {
        static void Main(string[] args)
        {
            string digit = Console.ReadLine();

            int number = 0;
            int multiplyNum = 1;
            int strongNum = 0;

            for (int i = 0; i < digit.Length; i++)
            {
                number = int.Parse(digit[i].ToString());


                for (int j = 1; j <= number; j++)
                {
                    multiplyNum *= j;
                }
                strongNum += multiplyNum;
                multiplyNum = 1;
            }
            int equal = int.Parse(digit);

            if (equal == strongNum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}