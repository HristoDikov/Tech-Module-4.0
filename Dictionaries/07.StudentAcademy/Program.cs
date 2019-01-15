using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentsGrades = new Dictionary<string, List<double>>();

            int studentsCount = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < studentsCount; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (studentsGrades.ContainsKey(studentName) == false)
                {
                    studentsGrades.Add(studentName, new List<double>());
                    studentsGrades[studentName].Add(grade);
                    
                }
                else
                {

                    studentsGrades[studentName].Add(grade);
                }
            }

            foreach (var student in studentsGrades.OrderByDescending(x => x.Value.ToList().Average()))
            {
                if (student.Value.ToList().Average() >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.ToList().Average():F2}");
                }
            }

        }
    }
}
