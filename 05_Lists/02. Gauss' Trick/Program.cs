//Write a program that sums all of the numbers in a list in the following order: 
//first + last, first + 1 + last - 1, first + 2 + last - 2, … first + n, last - n.

using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        public static object Select { get; private set; }

        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> summedList = new List<int>();

            for (int i = 0; i < input.Count / 2; i++)
            {
                summedList.Add(input[i] + input[input.Count - 1 - i]);
            }

            if (input.Count % 2 != 0)
            {
                summedList.Add(input[input.Count / 2]);
            }
            Console.WriteLine(string.Join(' ', summedList));
        }
    }
}
