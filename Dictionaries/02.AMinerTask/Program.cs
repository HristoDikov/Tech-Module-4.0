using System;
using System.Collections.Generic;

namespace _02.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, int>();
            var currentRes = " ";

            while (true)
            {
                string input = Console.ReadLine();
                currentRes = input;
                if (input == "stop")
                {
                    break;
                }

                if (!resources.ContainsKey(currentRes))
                {
                    resources.Add(currentRes, new int());
                }
                int quantity = int.Parse(Console.ReadLine());

                resources[currentRes] += quantity;
                currentRes = "";
            }

            foreach (var r in resources)
            {
                Console.WriteLine(r.Key + " -> " + r.Value);
            }
        }
    }
}
