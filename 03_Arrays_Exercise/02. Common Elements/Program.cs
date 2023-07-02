//Create a program that prints out all common elements in two arrays.
//You have to compare the elements of the second array to the elements of the first.

using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            string[] firstInput = Console.ReadLine().Split();
            string[] secondInput = Console.ReadLine().Split();

            foreach (var curentWord in firstInput)
            {
                for (int i = 0; i < secondInput.Length; i++)
                {
                    if (curentWord == secondInput[i])
                    {
                        Console.Write($"{curentWord} ");
                        break;
                    }
                }
            }
        }
    }
}
