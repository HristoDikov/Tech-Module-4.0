using System;
using System.Collections.Generic;

namespace _02.Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] textOne = Console.ReadLine().Split();
            string[] textTwo = Console.ReadLine().Split();
            List<string> commonElements = new List<string>();
            

            for (int i = 0; i < textTwo.Length; i++)
            {
                string comparator = textTwo[i];

                for (int j = 0; j < textOne.Length; j++)
                {
                    if (comparator == textOne[j])
                    {
                        commonElements.Add(comparator);
                    }
                }
            }
            Console.WriteLine(string.Join(" ",commonElements));
        }
    }
}
