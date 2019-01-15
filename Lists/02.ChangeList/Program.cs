using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();


            while (true)
            {
                string operations = Console.ReadLine();
                if (operations == "end")
                {
                    break;  
                }
                string[] commands = operations.Split(" ").ToArray();
                string command = commands[0];
                int number = int.Parse(commands[1]);

                if (command == "Insert")
                {
                    int index = int.Parse(commands[2]);
                    numbers.Insert(index, number);
                }
                else
                {
                    numbers.RemoveAll(n => n == number);
                }


            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
