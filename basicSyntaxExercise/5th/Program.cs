using System;

namespace _5th
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            for (int i = 0; i <= 3; i++)
            {
                string pass = Console.ReadLine();
                string reversed = "";
                for (int k = 0; k < pass.Length; k++)
                {
                    reversed += pass[pass.Length - 1 - k]; 
                }
                if (username == reversed)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                if (i == 3 && username != reversed)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                if (username != reversed)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
                
            }
            
        }
    }
}
