using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            while (true)
            {
                string operations = Console.ReadLine();

                if (operations == "End")
                {
                    break;
                }

                string[] commands = operations.Split(" ");
                string command = commands[0];
                

                if (command == "Add")
                {
                    int number = int.Parse(commands[1]);
                    numbers.Add(number);
                }
                if (command == "Insert")
                {
                    int number = int.Parse(commands[1]);
                    int index = int.Parse(commands[2]);
                    if (index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    if (index > numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    if(index >= 0 && index <= numbers.Count)
                    {
                        numbers.Insert(index, number);
                    }
                }
                if (command == "Remove")
                {
                    int number = int.Parse(commands[1]);
                    int index = number;
                    if (index < 0)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    if (index > numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    if(index >= 0 && index <= numbers.Count)
                    {
                        numbers.RemoveAt(index);
                    }
                }
                if (commands[1] == "left")
                {
                    int end = int.Parse(commands[2]);
                    numbers = ShiftLeft(numbers, end);
                }
                if (commands[1] == "right")
                {
                    int end = int.Parse(commands[2]);
                    numbers = ShiftRight(numbers, end);

                }


            }
            Console.WriteLine(string.Join(" ", numbers));
        }
        public static List<int> ShiftLeft(List<int> numbers, int end)
        {
            for (int i = 0; i < end; i++)
            {
                int firstNumber = numbers[0];
                numbers.RemoveAt(0);
                numbers.Add(firstNumber);
            }
            return numbers;
        }
        public static List<int> ShiftRight(List<int> numbers, int end)
        {
            for (int i = 0; i < end; i++)
            {
                int lastNumber = numbers[numbers.Count - 1];
                numbers.RemoveAt(numbers.Count - 1);
                numbers.Insert(0, lastNumber);
            }
            return numbers;
        }
    }
}
