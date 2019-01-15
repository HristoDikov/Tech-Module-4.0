using System;
using System.Collections.Generic;
using System.Linq;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());



            while (true)
            {
                string operation = Console.ReadLine();
                int i = 0;
                if (operation == "end")
                {
                    break;
                }
                string[] commands = operation.Split(" ").ToArray();
                string add = commands[0];


                int currentWagon = wagons[i];
                if (add == "Add")
                {
                    int number = int.Parse(commands[1]);
                    wagons.Add(number);
                }
                else
                {
                    int pplToAdd = int.Parse(add);
                    for (int j = 0; j < wagons.Count; j++)
                    {
                        if (wagons[j] + pplToAdd <= maxCapacity)
                        {
                            wagons[j] += pplToAdd;
                            break;
                        }
                    }

                }
                i++;

            }


            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
