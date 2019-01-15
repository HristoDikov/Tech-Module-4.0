using System;

namespace _06.MiddleChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            FindTheMiddleChar(text);
        }

        private static void FindTheMiddleChar(string text)
        {
            double length = text.Length;

            if (length % 2 != 0)
            {
                double end = Math.Ceiling(length / 2);

                for (int i = 0; i <= end; i++)
                {
                    if (i == end)
                    {
                        Console.WriteLine(text[i - 1]);
                        break;
                    }
                    
                }
            }
            else
            {
                double end = length / 2;

                for (int i = 0; i <= end; i++)
                {
                    if (i == end)
                    {
                        Console.Write(text[i - 1]);
                        Console.WriteLine(text[i]);
                        break;
                    }
                    
                }
            }
            
        }
    }
}
