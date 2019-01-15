using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                string[] personInfo = input.Split(" ");

                string name = personInfo[0];
                string id = personInfo[1];
                int age = int.Parse(personInfo[2]);

                Person person = new Person(name, id, age);

                people.Add(person);

            }
            Console.WriteLine(string.Join(Environment.NewLine, people.OrderBy(x=>x.Age)));
        }
    }
    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }

        public string Name { get; set; }

        public string Id { get; set; }

        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
}
