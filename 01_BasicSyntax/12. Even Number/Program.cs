﻿//Create a program that reads a sequence of numbers.
//If the number is even, print its absolute value in the following format:
//"The number is: {number}", and terminate the program.
//If the number is odd, print "Please write an even number." and continue reading numbers.

using System;

namespace _12EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int num = int.Parse(Console.ReadLine());

            while (num % 2 != 0)
            {
                Console.WriteLine("Please write an even number.");
                num = int.Parse(Console.ReadLine());
            }
            if (num % 2 == 0)
            {
                Console.WriteLine($"The number is: {Math.Abs(num)}");
            }
        }
    }
}
