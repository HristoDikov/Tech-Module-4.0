using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> secondPlayer = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            while(firstPlayer.Count != 0 && secondPlayer.Count != 0)
            {
                

                int firstPlayerCard = firstPlayer[0];
                int secondPlayerCard = secondPlayer[0];

                if (firstPlayerCard > secondPlayerCard)
                {
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);

                    firstPlayer.Add(firstPlayerCard);
                    firstPlayer.Add(secondPlayerCard);
                }
                else if (firstPlayerCard < secondPlayerCard)
                {
                    secondPlayer.RemoveAt(0);
                    firstPlayer.RemoveAt(0);

                    secondPlayer.Add(secondPlayerCard);
                    secondPlayer.Add(firstPlayerCard);
                }
                else if (firstPlayerCard == secondPlayerCard)
                {
                    firstPlayer.RemoveAt(0);
                    secondPlayer.RemoveAt(0);
                }
            }
            int result = 0;
            if (firstPlayer.Count == 0)
            {
                result = secondPlayer.Sum();
                Console.WriteLine($"Second player wins! Sum: {result}");
                
            }
            else if (secondPlayer.Count == 0)
            {
                result = firstPlayer.Sum();
                Console.WriteLine($"First player wins! Sum: {result}");
                
            }

        }
    }
}
