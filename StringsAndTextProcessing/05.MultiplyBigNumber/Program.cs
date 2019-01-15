using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberToMupltiply = Console.ReadLine().Trim('0');
            int mupltiplier = int.Parse(Console.ReadLine());

            string resultNumber = string.Empty;
            int onMind = 0;

            string reversedNumber = string.Join("", numberToMupltiply.ToCharArray().Reverse());

            if (numberToMupltiply == "0" || mupltiplier == 0)
            {
                Console.WriteLine(0);
                return;
            }

            for (int i = 0; i < reversedNumber.Length; i++)
            {
                int firstDigit = int.Parse(reversedNumber[i].ToString());
                int result = firstDigit * mupltiplier + onMind;

                resultNumber += result % 10;
                onMind = result / 10;

                if (i == reversedNumber.Length - 1 && onMind != 0)
                {
                    resultNumber += onMind;
                }
            }

            string resultFinale = string.Join("", resultNumber.ToCharArray().Reverse());

            Console.WriteLine(resultFinale);
        }
    }
}
