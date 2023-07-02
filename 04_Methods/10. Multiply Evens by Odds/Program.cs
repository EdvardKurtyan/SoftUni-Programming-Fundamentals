//You are given an input of two values of the same type. The values can be of type int, char, or string.
//Create methods called GetMax(), which can compare int, char, or string and returns the biggest of the two values.

using System;
using System.Linq;

namespace _00._Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int copyOfNumber = number;
            int numberLength = number.ToString().Length;

            int evenSum = 0;
            int oddSum = 0;
            for (int i = 0; i < numberLength; i++)
            {
                copyOfNumber %= 10;
                number /= 10;

                if (copyOfNumber % 2 == 0)
                {
                    evenSum += copyOfNumber;
                }
                else
                {
                    oddSum += copyOfNumber;
                }
                copyOfNumber = number;
            }
            Console.WriteLine(Math.Abs(evenSum * oddSum));
        }
    }
}
