//Read a list of integers and print them in ascending order, along with their number of occurrences.

using System;
using System.Collections.Generic;
using System.Linq;

namespace _00._Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine()
                .Split()
                .Select(number => int.Parse(number))
                .ToArray();

            SortedDictionary<int, int> occurrencesByNumbers = new SortedDictionary<int, int>();

            foreach (var curentNumber in input)
            {
                if (!occurrencesByNumbers.ContainsKey(curentNumber))
                {
                    occurrencesByNumbers.Add(curentNumber, 0);
                }
                occurrencesByNumbers[curentNumber]++;
            }

            foreach (var number in occurrencesByNumbers)
            {
                Console.WriteLine($"{number.Key} -> {number.Value}");
            }
        }
    }
}
