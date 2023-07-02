//Create a program that counts all characters in a string, except for space (' '). 
//Print all the occurrences in the following format:
//"{char} -> {occurrences}"

using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] word = Console.ReadLine().ToCharArray();
            var letters = new Dictionary<char, int>();

            foreach (var letter in word)
            {
                if (letter == ' ') continue;
                if (!letters.ContainsKey(letter))
                {
                    letters.Add(letter, 0);
                }
                letters[letter]++;
            }

            foreach (var letter in letters)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
