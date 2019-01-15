using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            var companyAndEmployee = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] items = input.Split(" -> ");

                string companyName = items[0];
                string id = items[1];

                if (companyAndEmployee.ContainsKey(companyName) == false)
                {
                    companyAndEmployee.Add(companyName, new List<string>());
                    companyAndEmployee[companyName].Add(id);

                }
                else
                {
                    if (companyAndEmployee[companyName].Contains(id))
                    {
                        continue;
                    }
                    companyAndEmployee[companyName].Add(id);
                }
            }
            foreach (var company in companyAndEmployee.OrderBy(x => x.Key))
            {
                Console.WriteLine(company.Key);
                foreach (var id in company.Value)
                {
                    Console.WriteLine($"-- {string.Join(" ", id)}");
                }
                
            }
        }
    }
}
