//Create a program, which prints all unique pairs in an array of integers whose sum is equal to a given number.

using System;
using System.Linq;

namespace _08._Magic_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < numbers.Length; i++)
            {
                int curentIndex = numbers[i];

                for (int t = i; t < numbers.Length; t++)
                {
                    if (input == curentIndex)
                    {
                        Console.WriteLine(curentIndex);
                        break;
                    }
                    if (input == curentIndex + numbers[t])
                    {
                        Console.WriteLine($"{curentIndex} {numbers[t]}");
                    }
                }
            }
        }
    }
}
