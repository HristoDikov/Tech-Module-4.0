using System;


namespace _02.CharMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] twoStrings = Console.ReadLine().Split(" ");

            string firstString = twoStrings[0];
            string secString = twoStrings[1];

            int minLength = Math.Min(firstString.Length, secString.Length);
            int maxLength = Math.Max(firstString.Length, secString.Length);

            int result = 0;

            for (int i = 0; i < minLength; i++)
            {
                int charFirstString = firstString[i];
                int charSecString = secString[i];

                result += (charFirstString * charSecString);

            }

            if (firstString.Length > secString.Length)
            {
                for (int i = minLength; i < maxLength; i++)
                {
                    result += firstString[i];
                }
            }
            if (secString.Length > firstString.Length)
            {
                for (int i = minLength; i < maxLength; i++)
                {
                    result += secString[i];
                }
            }
            

            Console.WriteLine(result);
        }
    }
}
