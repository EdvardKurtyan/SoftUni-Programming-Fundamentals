//Create a program that sorts some students by their grade in descending order. Each student should have:
//•	First name(String)
//•	Last name(String)
//•	Grade(a floating - point number)
//Input
//•	On the first line, you will receive a number n - the count of all students
//•	On the next n lines, you will be receiving information about these students in the following format: "{first name} {second name} {grade}"
//Output
//•	Print out the information about each student in the following format: "{first name} {second name}: {grade}"

using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            List<Student> allStudents = new List<Student>();

            for (int i = 0; i < studentsCount; i++)
            {
                string[] input = Console.ReadLine().Split();
                Student curentStudent = new Student(input[0], input[1], double.Parse(input[2]));
                allStudents.Add(curentStudent);
            }

            List<Student> sortedStudents = allStudents.OrderByDescending(allStudents => allStudents.Grade).ToList();
            foreach (var student in sortedStudents)
            {
                Console.WriteLine(student);
            }
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

        public override string ToString() => $"{FirstName} {LastName}: {Grade:f2}";
    }
}
