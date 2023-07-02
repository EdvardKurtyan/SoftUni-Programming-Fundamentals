//Create a program that creates 2 arrays. You will be given an integer n.
//On the next n lines, you will get 2 integers.
//Form 2 new arrays in a zig-zag pattern as shown below.

using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int lines = int.Parse(Console.ReadLine());
            int[] evenLine = new int[lines];
            int[] oddLine = new int[lines];

            for (int i = 0; i < lines; i++)
            {
                int[] curentLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
                
                if (i % 2 == 0)
                {
                    evenLine[i] = curentLine[0];
                    oddLine[i] = curentLine[1];
                }
                else
                {
                    evenLine[i] = curentLine[1];
                    oddLine[i] = curentLine[0];
                }
            }
            Console.WriteLine(String.Join(" ", evenLine));
            Console.WriteLine(String.Join(" ", oddLine));
        }
    }
}


