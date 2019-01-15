using System;
using System.Collections.Generic;

namespace _01._AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            var itemPrice = new Dictionary<string, decimal>();
            var itemQuantity = new Dictionary<string, int>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "buy")
                {
                    break;
                }

                string[] commands = input.Split(" ");
                string item = commands[0];
                decimal price = decimal.Parse(commands[1]);
                int quantity = int.Parse(commands[2]);

                if (!itemPrice.ContainsKey(item))
                {
                    itemPrice[item] = price;
                    itemQuantity[item] = quantity;
                }
                else if (itemPrice.ContainsKey(item))
                {
                    itemPrice[item] = price;
                    itemQuantity[item] += quantity;
                }
            }

            foreach (var kvp in itemQuantity)
            {
                string item = kvp.Key;
                int quantity = kvp.Value;
                decimal price = itemPrice[kvp.Key];

                Console.WriteLine($"{item} -> {quantity * price:F2}");

            }
        }
    }
}
