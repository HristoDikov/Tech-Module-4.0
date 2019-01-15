using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _04.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < countOfStudents; i++)
            {
                string[] splittedInput = Console.ReadLine()
                    .Split(" ");

                string firstName = splittedInput[0];
                string lastName = splittedInput[1];
                double grade = double.Parse(splittedInput[2]);

                Student student = new Student(firstName, lastName, grade);
                students.Add(student);
            }
            Console.WriteLine(string.Join(Environment.NewLine, students.OrderByDescending(x=>x.Grade)));
        }
    }
    class Student
    {
        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        
        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:F2}";
        }
    }
}
