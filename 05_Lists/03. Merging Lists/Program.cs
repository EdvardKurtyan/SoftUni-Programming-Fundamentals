//You are going to receive two lists with numbers.
//Create a result list, which contains the numbers from both of the lists.
//The first element should be from the first list, the second from the second list and so on.
//If the length of the two lists are not equal, just add the remaining elements at the end of the list.

using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstInput = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> SecondInput = Console.ReadLine().Split().Select(int.Parse).ToList();

            int biggerList = Math.Max(firstInput.Count, SecondInput.Count);

            List<int> summedResult = new List<int>();

            for (int i = 0; i < biggerList; i++)
            {
                if (i <= firstInput.Count - 1)
                {
                    summedResult.Add(firstInput[i]);
                }
                if (i <= SecondInput.Count - 1)
                {
                    summedResult.Add(SecondInput[i]);
                }
            }
            Console.WriteLine(string.Join(' ', summedResult));
        }
    }
}
