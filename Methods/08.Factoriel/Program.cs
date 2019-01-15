using System;

namespace _08.Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstInteger = double.Parse(Console.ReadLine());
            double secondInteger = double.Parse(Console.ReadLine());

            double firstFactoriel = FindingFactoriel(firstInteger);
            double secondFactoriel = FindingFactoriel(secondInteger);
            double result = FindingTheResult(firstFactoriel, secondFactoriel);

            Console.WriteLine($"{result:F2}");
            
        }

        private static double FindingTheResult(double firstFactoriel, double secondFactoriel)
        {        
                double result = firstFactoriel / secondFactoriel;
                return result;
        }

        private static double FindingFactoriel(double firstInteger)
        {
            double factoriel = 1;
            for (double i = 1; i < firstInteger; i++)
            {
                factoriel *= i + 1;
            }
            return factoriel;
        }
    }
}
