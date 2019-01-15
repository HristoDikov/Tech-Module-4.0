using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            var items = new Dictionary<string, int>();
            var junkItems = new Dictionary<string, int>();

            int shadowMourne = 0;
            int valanyr = 0;
            int dragonwrath = 0;

            while (shadowMourne < 250 && valanyr < 250 && dragonwrath < 250)
            {
                string[] input = Console.ReadLine()
                    .ToLower()
                    .Split(" ");

                for (int i = 0; i < input.Length; i++)
                {
                    if (i % 2 != 0)
                    {
                        if (input[i] != "shards" && input[i] != "fragments" && input[i] != "motes")
                        {
                            junkItems.Add(input[i], int.Parse(input[i + 1]));
                        }
                        else
                        {
                            if (items.ContainsKey(input[i]))
                            {
                                int value = int.Parse(input[i - 1]);
                                items[input[i]] += value;
                            }
                            else if (!items.ContainsKey(input[i]))
                            {
                                int value = int.Parse(input[i - 1]);
                                items.Add(input[i], value);
                            }

                        }

                    }
                    if (input[i].ToLower() == "shards")
                    {
                        shadowMourne += int.Parse(input[i - 1]);
                    }
                    else if (input[i].ToLower() == "fragments")
                    {
                        valanyr += int.Parse(input[i - 1]);
                    }
                    else if (input[i].ToLower() == "motes")
                    {
                        dragonwrath += int.Parse(input[i - 1]);
                    }
                }
            }
            if (valanyr >= 250)
            {
                Console.WriteLine("Valanyr obtained");
                items["fragments"] -= 250;
            }
            else if (dragonwrath >= 250)
            {
                Console.WriteLine("Dragonwrath obtained");
                items["motes"] -= 250;

            }
            else if (shadowMourne >= 250)
            {
                Console.WriteLine("Shadowmourne obtained");
                items["shards"] -= 250;

            }

            foreach (var i in items.OrderByDescending(i => i.Value).ThenBy(i => i.Key))
            {
                Console.WriteLine(i.Key + ": " + i.Value);
            }
            foreach (var i in junkItems.OrderBy(i => i.Key))
            {
                Console.WriteLine(i.Key + ": " + i.Value);
            }
            
        }
    }
}
