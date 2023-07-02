//You will be given a string that will contain words separated by a single space.
//Randomize their order and print each word on a new line.

using System;
using System.Collections.Generic;

namespace _01._Randomize_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentence = Console.ReadLine().Split();

            Random randomWord = new Random();

            List<string> randomSenetece = new List<string>();

            for (int i = 0; i < sentence.Length; i++)
            {
                int randomIndex = randomWord.Next(sentence.Length);

                randomSenetece.Add(sentence[randomIndex]);
            }

            foreach (var word in randomSenetece)
            {
                Console.WriteLine(word);
            }
        }
    }
}
