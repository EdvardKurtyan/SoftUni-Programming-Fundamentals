//Create a program, which keeps a dictionary with synonyms. The key of the dictionary will be the word.
//The value will be a list of all the synonyms of that word. You will be given a number n – the count of the words.
//After each word, you will be given a synonym, so the count of lines you have to read from the console is 2 * n.
//You will be receiving a word and a synonym each on a separate line like this:
//•	{ word}
//•	{ synonym}
//If you get the same word twice, just add the new synonym to the list.
//Print the words in the following format:
//"{word} - {synonym1, synonym2, …, synonymN}"

using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> synonyms = new Dictionary<string, List<string>>();

            List<string> allSynonyms = new List<string>();

            for (int i = 0; i < lines; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();
                allSynonyms.Add(synonym);

                if (!synonyms.ContainsKey(word))
                {
                    synonyms.Add(word, new List<string>());
                }
                synonyms[word].Add(synonym);
            }

            foreach (var curentWord in synonyms)
            {
                Console.WriteLine($"{curentWord.Key} - {string.Join(", ", curentWord.Value)}");
            }
        }
    }
}
