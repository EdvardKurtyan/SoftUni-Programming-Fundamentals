//Read two arrays and determine whether they are identical or not.
//The arrays are identical if all their elements are equal.
//If the arrays are identical find the sum of the elements of one of them and print the following message to the console:
//"Arrays are identical. Sum: {sum}"
//Otherwise, find the first index where the arrays differ and print the following message to the console:
//"Arrays are not identical. Found difference at {index} index."

using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // V
            int[] firstLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondLine = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int sum = 0;

            for (int i = 0; i < firstLine.Length; i++)
            {
                for (int t = i; t < secondLine.Length;)
                {
                    if (firstLine[i] == secondLine[t])
                    {
                        sum += firstLine[i];
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                        return;
                    }
                }
            }
            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}

