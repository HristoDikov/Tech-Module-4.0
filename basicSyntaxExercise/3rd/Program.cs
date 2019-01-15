using System;

namespace _3rd
{
    class Program
    {
        static void Main(string[] args)
        {

            double ppl = double.Parse(Console.ReadLine());
            string form = Console.ReadLine();
            string days = Console.ReadLine();
            double price = 0;
            double disc = 0;
            
            if (days == "Friday")
            {
                if (form == "Students")
                {
                    price = ppl * 8.45;
                    if (ppl >= 30)
                    {
                        disc = price * 0.15;
                        price -= disc;
                    }
                }
                if (form == "Business")
                {
                    price = ppl * 10.90;
                    if (ppl >= 100)
                    {
                        disc = 10 * 10.90;
                        price -= disc;
                    }
                }
                if (form == "Regular")
                {
                    price = ppl * 15;
                    if (ppl >= 10 && ppl <= 20)
                    {
                        disc = price * 0.05;
                        price -= disc;
                    }
                    
                }
            }
            if (days == "Saturday")
            {
                if (form == "Students")
                {
                    price = ppl * 9.8;
                    if (ppl >= 30)
                    {
                        disc = price * 0.15;
                        price -= disc;
                    }
                }
                if (form == "Business")
                {
                    price = ppl * 15.60;
                    if (ppl >= 100)
                    {
                        disc = 10 * 15.60;
                        price -= disc;
                    }
                }
                if (form == "Regular")
                {
                    price = ppl * 20;
                    if (ppl >= 10 && ppl <= 20)
                    {
                        disc = price * 0.05;
                        price -= disc;
                    }
                   
                }
            }
            if (days == "Sunday")
            {
                if (form == "Students")
                {
                    price = ppl * 10.46;
                    if (ppl >= 30)
                    {
                        disc = price * 0.15;
                        price -= disc;
                    }
                }
                if (form == "Business")
                {
                    price = ppl * 16;

                    if (ppl >= 100)
                    {
                        disc = 10 * 16;
                        price -= disc;
                    }
                    
                    
                }
                if (form == "Regular")
                {
                    price = ppl * 22.50;
                    

                    if (ppl >= 10 && ppl <= 20)
                    {
                        disc = price * 0.05;
                        price -= disc;
                    }
                    
                    
                }
            }
            Console.WriteLine($"Total price: {price:F2}");
        }
    }
}
