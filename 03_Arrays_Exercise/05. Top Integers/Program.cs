//Create a program to find all the top integers in an array.
//A top integer is an integer that is greater than all the elements to its right.

using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            // V
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int topNum = int.MinValue;
            int[] topNumArr = new int[arr.Length];

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (topNum < arr[i])
                {
                    topNum = arr[i];
                    topNumArr[i] = topNum;
                }
            }
            foreach (var curentNumber in topNumArr)
            {
                if (curentNumber != 0)
                {
                    Console.Write(curentNumber + " ");
                }
            }

        }
    }
}
