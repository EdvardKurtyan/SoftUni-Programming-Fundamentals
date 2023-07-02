﻿//Read an array of strings and take only words, whose length is an even number. Print each word on a new line.

using System;
using System.Linq;

namespace _04._Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .Where(n => n.Length % 2 == 0)
                .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
