//Create a program that keeps the information about courses. Each course has a name and registered students.
//You will be receiving a course name and a student name, until you receive the command "end".
//Check if such a course already exists, and if not, add the course. Register the user into the course.
//When you receive the command "end", print the courses with their names and total registered users.
//For each contest print the registered users.
//Input
//•	Until the "end" command is received, you will be receiving input in the format: "{courseName} : {studentName}".
//•	The product data is always delimited by " : ".
//Output
//•	Print the information about each course in the following the format: 
//"{courseName}: {registeredStudents}"
//•	Print the information about each student in the following the format:
//"-- {studentName}"

using System;
using System.Collections.Generic;

namespace _05._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();
            var studentsCountPerCourse = new Dictionary<string, int>();
            //List<string> allStudents = new List<string>();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end") break;
                string[] input = command.Split(" : ");
                string courseName = input[0];
                string student = input[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }
                courses[courseName].Add(student);
            }
            foreach (var course in courses)
            {
                string courseName = course.Key;
                var students = course.Value;
                Console.WriteLine($"{courseName}: {students.Count}");
                foreach (var student in students)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
