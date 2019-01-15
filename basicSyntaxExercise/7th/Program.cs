using System;
using System.Collections.Generic;
using System.Linq;

namespace _7th
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal wallet = 0;
            string money;
            string product;

            Dictionary<string, decimal> productsAvailable = new Dictionary<string, decimal>()
            {
                {"nuts",(decimal)2.0},
                {"water",(decimal)0.7},
                {"crisps",(decimal)1.5},
                {"soda",(decimal)0.8},
                {"coke",(decimal)1},
            };

            decimal[] coinsAvailable = new decimal[]
            {
                (decimal)0.1,
                (decimal)0.2,
                (decimal)0.5,
                (decimal)1,
                (decimal)2
            };

            money = Console.ReadLine().ToLower();

            while (money != "start")
            {
                if (coinsAvailable.Contains(decimal.Parse(money)))
                {
                    wallet += decimal.Parse(money);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                }
                money = Console.ReadLine().ToLower();
            }

            product = Console.ReadLine().ToLower();

            while (product != "end")
            {
                if (productsAvailable.ContainsKey(product))
                {
                    if (wallet >= productsAvailable[product])
                    {
                        wallet -= productsAvailable[product];
                        Console.WriteLine($"Purchased {product.ToLower()}");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                    
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
               product = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Change: {wallet:F2}");
        }
    }
}
