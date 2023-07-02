//You will be given a series of strings until you receive an "end" command.
//Write a program that reverses strings and prints each pair on a separate line in the format "{word} = {reversed word}".

using System;
using System.Collections.Generic;

namespace _01._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reversed = string.Empty;

            while (input != "end")
            {
                for (int i = input.Length - 1; 0 <= i; i--)
                {
                    reversed += input[i];
                }
                Console.WriteLine($"{input} = {reversed}");
                reversed = string.Empty;
                input = Console.ReadLine();
            }
        }
    }
}
