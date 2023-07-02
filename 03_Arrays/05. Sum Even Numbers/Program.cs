//Read an array from the console and sum only its even values. 

using System;
using System.Linq;

namespace _05._Sum_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // V 
            string input = Console.ReadLine();
            string[] numbersAsString = input.Split(" ");
            int[] numbers = new int[numbersAsString.Length];
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(numbersAsString[i]);
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            Console.WriteLine(sum);

            //                        Optimised code

            //int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            //
            //int sum = 0;
            //for (int i = 0; i < input.Length; i++)
            //{
            //    if (input[i] % 2 == 0)
            //    {
            //        sum += input[i];
            //    }
            //}
            //Console.WriteLine(sum);
        }
    }
}
