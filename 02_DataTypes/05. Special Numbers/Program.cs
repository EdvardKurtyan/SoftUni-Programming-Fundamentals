﻿//A number is special when its sum of digits is 5, 7, or 11.
//Write a program to read an integer n and for all numbers in the range 1…n to print the number and if it is special or not (True / False).

using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int count = int.Parse(Console.ReadLine());
            for (int i = 1; i <= count; i++)
            {
                int sumOfDigits = 0;
                int digit = i;

                while (digit != 0)
                {
                    sumOfDigits += digit % 10;
                    digit = digit / 10;
                }

                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
