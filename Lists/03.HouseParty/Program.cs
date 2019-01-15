using System;
using System.Collections.Generic;

namespace _03.HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = new List<string>();
            int commands = int.Parse(Console.ReadLine());

            for (int i = 0; i < commands; i++)
            {
                string guest = Console.ReadLine();
                string[] command = guest.Split(" ");
                string name = command[0];

                if (command[2] == "going!")
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
                else
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }

            }
            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
            
        }
    }
}
