using System;

namespace basicSyntaxExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            if (input >= 0 && input <= 2 )
            {
                Console.WriteLine("baby");
            }
            if (input >= 3 && input <= 13)
            {
                Console.WriteLine("child");
            }
            if (input >= 14 && input <= 19)
            {
                Console.WriteLine("teenager");
            }
            if (input >= 20 && input <= 65)
            {
                Console.WriteLine("adult");
            }
            if (input >= 66)
            {
                Console.WriteLine("elder");
            }
        }
    }
}
