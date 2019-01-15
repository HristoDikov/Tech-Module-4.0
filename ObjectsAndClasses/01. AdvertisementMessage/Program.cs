using System;
using System.Collections.Generic;

namespace _01._AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int countMessages = int.Parse(Console.ReadLine());

            var phrases = new List<string> { "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product." };

            var events = new List<string> { "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" };

            var authors = new List<string> { "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva" };

            var cities = new List<string> { "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse" };

            Random random = new Random();

            for (int i = 0; i < countMessages; i++)
            {
                string phrase = phrases[random.Next(0, phrases.Count)];
                string @event = events[random.Next(0, events.Count)];
                string author = authors[random.Next(0, authors.Count)];
                string city = cities[random.Next(0, cities.Count)];

                Console.WriteLine($"{phrase} {@event} {author} – {city}.");
            }

        }
    }
}
