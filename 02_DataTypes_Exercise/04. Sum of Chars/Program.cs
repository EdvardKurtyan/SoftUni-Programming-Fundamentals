//Create a program, which sums the ASCII codes of n characters and prints the sum on the console.

using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int n = int.Parse(Console.ReadLine());
            int sumOfDigits = 0;

            for (int i = 0; i < n; i++)
            {
                char digit = char.Parse(Console.ReadLine());
                int curentDigit = (int)digit;
                sumOfDigits += digit;
            }
            Console.WriteLine($"The sum equals: {sumOfDigits}");
        }
    }
}
