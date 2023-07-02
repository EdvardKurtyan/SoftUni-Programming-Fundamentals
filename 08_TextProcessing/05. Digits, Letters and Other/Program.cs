//Create a program that receives a single string and on the first line prints all the digits, on the second –
//all the letters, and on the third – all the other characters.
//There will always be at least one digit, one letter, and one other character.

using System;
using System.Text;

namespace _05._Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            StringBuilder digits = new StringBuilder(); 
            StringBuilder letters = new StringBuilder();
            StringBuilder characters = new StringBuilder();

            foreach (var ch in input)
            {
                if (char.IsDigit(ch))
                {
                    digits.Append(ch);
                }
                else if (char.IsLetter(ch))
                {
                    letters.Append(ch);
                }
                else if (!char.IsLetterOrDigit(ch))
                {
                    characters.Append(ch);
                }
            }
            Console.WriteLine(digits);
            Console.WriteLine(letters);
            Console.WriteLine(characters);
        }
    }
}
