using System;
using System.Collections.Generic;

namespace _05.SoftuniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            var customers = new Dictionary<string, string>();
            int nOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < nOfCommands; i++)
            {
                string input = Console.ReadLine();

                string[] commands = input.Split(" ");

                string command = commands[0];
                string name = commands[1];
                

                if (command == "register")
                {
                    string licenseNum = commands[2];

                    if (customers.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licenseNum}");
                    }
                    else
                    {
                        Console.WriteLine($"{name} registered {licenseNum} successfully");
                        customers.Add(name, licenseNum);
                    }
                }
                else if (command == "unregister")
                {
                    if (!customers.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        Console.WriteLine($"{name} unregistered successfully");
                        customers.Remove(name);
                    }
                }
            }

            foreach (var customer in customers)
            {
                Console.WriteLine($"{customer.Key} => {customer.Value}");
            }

        }
    }
}
