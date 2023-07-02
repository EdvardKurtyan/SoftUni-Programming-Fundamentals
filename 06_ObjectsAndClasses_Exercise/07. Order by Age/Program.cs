// You will receive an unknown number of lines. On each line you will receive an array with 3 elements:
//· The first element is a string - the name of the person
//· The second element a string - the ID of the person
//· The third element is an integer - the age of the person
//If you get a person whose ID you have already received before, update the name and age for that ID with that of
//  the new person.When you receive the command "End", print all of the people, ordered by age.

using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End") break;
                string[] input = command.Split();
                string name = input[0];
                string id = input[1];
                int age = int.Parse(input[2]);

                Person person = new Person(name, id, age);
                people.Add(person);

                for (int i = 0; i < people.Count; i++)
                {
                    if (people[i].ID == people[people.Count - 1].ID && i != people.Count-1)
                    {
                        people.RemoveAt(i);
                    }
                }
            }
            List<Person> sortedByAge = people.OrderBy(t => t.Age).ToList();
            foreach (var person in sortedByAge)
            {
                Console.WriteLine(person);
            }
        }
    }
    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
        public override string ToString() => $"{Name} with ID: {ID} is {Age} years old.";
    }
}
