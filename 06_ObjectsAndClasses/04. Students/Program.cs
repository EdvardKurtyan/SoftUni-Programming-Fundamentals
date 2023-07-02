//Define a class called Student, which will hold the following information about some students: 
//•	first name
//•	last name
//•	age
//•	home town
//Input / Constraints
//Read information about some students, until you receive the "end" command. After that, you will receive a city name.
//Output
//Print the students who are from the given city in the following format: "{firstName} {lastName} is {age} years old."

using System;
using System.Collections.Generic;

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

                string[] studentsDetails = command.Split();

                Student student = new Student
                {
                    FirstName = studentsDetails[0],
                    LastName = studentsDetails[1],
                    Age = int.Parse(studentsDetails[2]),
                    HomeTown = studentsDetails[3]
                };

                allStudents.Add(student);

            }

            string city = Console.ReadLine();

            foreach (Student currentStudent in allStudents)
            {
                if (currentStudent.HomeTown == city)
                {
                    //John Smith is 15 years old
                    Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName} is {currentStudent.Age} years old.");
                }
            }
        }
    }
    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
