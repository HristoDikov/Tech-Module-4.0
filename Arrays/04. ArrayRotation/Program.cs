using System;

namespace _04._ArrayRotation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split();
            int count = int.Parse(Console.ReadLine());

            for (int i = 1; i <= count; i++)
            {
                string lastNum = text[0];
                

                for (int j = 0; j < text.Length - 1; j++)
                {
                    text[j] = text[j + 1];
                }
                text[text.Length - 1] = lastNum;
            }
            Console.WriteLine(string.Join(" ", text));

        }
    }
}
