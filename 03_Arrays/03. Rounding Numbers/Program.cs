//Read an array of real numbers (space separated), round them in "away from 0" style, and print the output as in the examples:

using System;

namespace _03._Rounding_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            string input = Console.ReadLine();
            string[] numbersAsString = input.Split(" ");
            double[] numbers = new double[numbersAsString.Length];

            for (int i = 0; i < numbersAsString.Length; i++)
            {
                numbers[i] = double.Parse(numbersAsString[i]);
            }

            for (int t = 0; t < numbers.Length; t++)
            {
                Console.WriteLine($"{numbers[t]} => {(int)Math.Round(numbers[t], MidpointRounding.AwayFromZero)}");
            }
        }
    }
}
