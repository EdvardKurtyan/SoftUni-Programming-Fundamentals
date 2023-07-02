//Create a program that reads an array of strings, reverses it, and prints its elements.
//The input consists of a sequence of space-separated Strings.
//Print the output on a single line (space separated).

using System;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            string[] input = Console.ReadLine().Split(' ');

            for (int i = input.Length - 1; i >= 0; i--)
            {
                Console.Write($"{input[i]} ");  
            }

            //                        Optimised code 

            //Array.Reverse(input);
            //Console.WriteLine(String.Join(" ",input));
        }
    }
}
