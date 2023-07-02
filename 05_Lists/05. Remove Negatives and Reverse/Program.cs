//Read a list of integers, remove all negative numbers from it and print the remaining elements in reversed order.
//In case there are no elements left in the list, print "empty".

using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Remove_Negatives_and_Reverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            input.RemoveAll(i => i < 0);
            input.Reverse();

            if (input.Count > 0)
            {
                Console.WriteLine(string.Join(' ', input));
                return;
            }

            Console.WriteLine("empty");
        }
    }
}
