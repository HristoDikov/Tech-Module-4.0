using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();

            while (true)
            {
                string input = Console.ReadLine();


                if (input == "end")
                {
                    break;
                }

                string[] commands = input.Split(" : ");

                string course = commands[0];
                string student = commands[1];

                List<string> students = new List<string>();

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new List<string>());
                    courses[course].Add(student);
                }
                else
                {
                    courses[course].Add(student);
                }
            }
            foreach (var kvp in courses.OrderByDescending(x=> x.Value.Count()))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count()}");
                foreach (var student in kvp.Value.OrderBy(s => s))
                {
                    Console.WriteLine($"-- {student}");
                }
                
            }
        }
    }
}
