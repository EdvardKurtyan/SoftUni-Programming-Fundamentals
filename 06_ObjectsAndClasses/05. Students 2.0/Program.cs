//Use the class from the previous problem.
//If you receive a student, which already exists (first name and last name should be unique) overwrite the information.

using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> allStudents = new List<Student>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end") break;
                string[] input = command.Split();
                string firstName = input[0];
                string lastName = input[1];

                if (!IsStudentExisting(allStudents, firstName, lastName))
                {
                    Student newStudent = new Student(input[0], input[1], int.Parse(input[2]), input[3]);
                    allStudents.Add(newStudent);
                    continue;
                }
                Student student = new Student(input[0], input[1], int.Parse(input[2]), input[3]);
                allStudents.Add(student);
            }
            string cityToPrint = Console.ReadLine();
            foreach (var student in allStudents)
            {
                if (student.City == cityToPrint)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }

        private static bool IsStudentExisting(List<Student> allStudents, string firstName, string lastName)
        {
            foreach (var student in allStudents)
            {
                if (student.FirstName == firstName && student.LastName == lastName)
                {
                    allStudents.Remove(student);
                    return false;
                }
            }
            return true;
        }
    }
    class Student
    {
        public Student(string firstName, string lastName, int age, string city)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            City = city;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
}
