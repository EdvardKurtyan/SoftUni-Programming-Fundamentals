//Create a program that extracts all elements from a given sequence of words that are present in it an odd number of times (case-insensitive).
//•	Words are given on a single line, space-separated.
//•	Print the result elements in lowercase, in their order of appearance.

using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            List<string> input = Console.ReadLine()
                .Split()
                .Select(word => word.ToLower())
                .ToList();

             foreach (var curentWord in input)
             {
                 if (!words.ContainsKey(curentWord))
                 {
                     words.Add(curentWord, 0);
                 }
                 words[curentWord]++;
             }

            string[] oddWordCount = words
               .Where(w => w.Value % 2 != 0)
               .Select(w => w.Key)
               .ToArray();

            Console.WriteLine(string.Join(" ", oddWordCount));
        }
    }
}
