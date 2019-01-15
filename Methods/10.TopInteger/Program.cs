using System;
using System.Collections.Generic;

namespace _10.TopInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            var divisibleDigits = SumOfDigits(number);
            var divDigitsWithOddNum = findOddDigits(divisibleDigits);
            Console.WriteLine(string.Join(" ", divDigitsWithOddNum));
        }

        private static List<int> findOddDigits(List<int> divisibleDigits)
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < divisibleDigits.Count; i++)
            {
                int addingNumber = i;
                
                int lastNumber = 0;
                while (divisibleDigits[i] > 0)
                {
                    lastNumber = i % 10;
                    if (lastNumber % 2 != 0)
                    {
                        numbers.Add(addingNumber);
                        break;
                    }
                    i /= 10;
                }

            }
            return numbers;
        }

        public static List<int> SumOfDigits(int number)
        {
            List<int> numbers = new List<int>();
            int sum = 0;
            for (int i = 11; i < number; i++)
            {

                int ii = i;
                int lastNumber = 0;
                while (ii > 0)
                {
                    lastNumber = ii % 10;
                    sum += lastNumber;
                    ii /= 10;
                }
                if (sum % 8 == 0)
                {
                    numbers.Add(i);
                }
                sum = 0;
            }
            return numbers;
        }

    }
}
