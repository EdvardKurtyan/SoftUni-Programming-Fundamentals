﻿//Write a program to sum all adjacent equal numbers in a list of decimal numbers, starting from left to right.
//	After two numbers are summed, the obtained result could be equal to some of its neighbors and should be summed as well (see the examples below).
//	Always sum the leftmost two equal neighbors (if several couples of equal neighbors are available).

using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < input.Count; i++)
            {
                if (input.Count - 1 > i)
                {
                    if (input[i] == input[i + 1])
                    {
                        input[i] = input[i] + input[i + 1];
                        input.RemoveAt(i + 1);
                        i = -1;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}
