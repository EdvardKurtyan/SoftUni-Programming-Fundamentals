//Create a program that keeps the information about students and their grades. 
//You will receive n pair of rows. First, you will receive the student's name, after that, you will receive their grade.
//Check if the student already exists and if not, add him. Keep track of all grades for each student.
//When you finish reading the data, keep the students with an average grade higher than or equal to 4.50.
//Print the students and their average grade in the following format:
//"{name} –> {averageGrade}"
//Format the average grade to the 2nd decimal place.

using System;
using System.Collections.Generic;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();
            string input;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split(new string[] { " : " }, StringSplitOptions.None);
                string course = commands[0];
                string student = commands[1];
                if (!courses.ContainsKey(course))
                    courses.Add(course, new List<string>());
                courses[course].Add(student);
            }

            foreach (KeyValuePair<string, List<string>> course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                course.Value.ForEach(x => Console.WriteLine($"-- {x}"));
            }

        }
    }
}
