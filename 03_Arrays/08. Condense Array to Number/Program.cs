//Create a program to read an array of integers and condense them
//by summing all adjacent couples of elements until a single integer remains.
//For example, let us say we have 3 elements - {2, 10, 3}.
//We sum the first two and the second two elements and get {2 + 10, 10 + 3} = { 12, 13},
//then we sum all adjacent elements again. This results in {12 + 13} = { 25}.

using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            // V
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[numbers.Length - 1];

            while (numbers.Length > 1)
            {
                for (int i = 0; i <= numbers.Length - 2; i++)
                {
                    condensed[i] = numbers[i] + numbers[i + 1];

                    if (i == numbers.Length - 2)
                    {
                        numbers = condensed;
                        condensed = new int[numbers.Length - 1];
                    }
                }
            }

            Console.WriteLine(numbers[0]);
        }
    }
}
