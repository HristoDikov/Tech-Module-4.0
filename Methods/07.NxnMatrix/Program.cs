using System;

namespace _07.NxnMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            NxnMatrix(count);
        }

        private static void NxnMatrix(int count)
        {
            for (int i = 0; i < count; i++)
            {
                for (int j = 0; j < count ; j++)
                {
                    Console.Write(count + " ");
                    if (j == count - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
