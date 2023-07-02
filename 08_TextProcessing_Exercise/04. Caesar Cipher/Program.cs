//Create a program that returns an encrypted version of the same text.
//Encrypt the text by shifting each character with three positions forward.
//For example, A would be replaced by D, B would become E, and so on
//. Print the encrypted text.

using System;
using System.Collections.Generic;

namespace _04._Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<char> encrypted = new List<char>();

            foreach (var curentChar in input)
            {
                int ch = curentChar + 3;
                encrypted.Add((char)ch);
            }
            foreach (var item in encrypted)
            {
                Console.Write(item);
            }
        }
    }
}
