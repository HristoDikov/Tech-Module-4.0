using System;

namespace _03.ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("\\");

            string[] nameExtension = input[input.Length-1].Split(".");

            string fileName = nameExtension[0];
            string extension = nameExtension[1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");

        }
    }
}
