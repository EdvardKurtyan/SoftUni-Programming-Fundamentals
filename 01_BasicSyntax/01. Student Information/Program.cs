﻿//Create a program that receives 3 lines of input:
//•	student name 
//•	age
//•	average grade. 
//Your task is to print all the info about the student in the following format:
//"Name: {student name}, Age: {student age}, Grade: {student grade}".

using System;

namespace BasicSyntaxConditionalStatementsAndLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //v
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: " +
                $"{age}, Grade: {grade:f2}");
        }
    }
}
