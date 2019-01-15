using System;
using System.Linq;

namespace _07.MaxSeqOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int bestSeq = 1; 
            int bestNum = 0; 
            int currSeq = 1; 
            int currNum = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                currNum = numbers[i];
                

                for (int k = i + 1; k < numbers.Length; k++)
                {
                    if (currNum == numbers[k])
                    {
                        currSeq++;

                    }
                    else
                    {
                        break;
                    }
                    

                }
                if (currSeq > bestSeq)
                {
                    bestSeq = currSeq;
                    bestNum = currNum;
                    
                }
                currSeq = 1;
            }
            for (int i = 0; i < bestSeq; i++)
            {
                Console.Write(bestNum + " ");
            }
            Console.WriteLine();
        }
    }
}
