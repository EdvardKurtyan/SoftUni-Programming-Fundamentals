//Create a program that receives an integer as an input. Print the 10 times table for this integer.

using System;

namespace _10MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{input} X {i} = {input * i}");
            }
        }
    }
}
