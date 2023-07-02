//A single integer is given, create a method that checks if the given number is positive, negative, or zero. As a result print:
//•	For positive number: "The number {number} is positive. "
//•	For negative number: "The number {number} is negative. "
//•	For zero number: "The number {number} is zero. "

using System;

namespace _01._Sign_of_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            SignOfInteger(number);
        }

        static void SignOfInteger(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
