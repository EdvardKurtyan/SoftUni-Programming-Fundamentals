//Create a method that receives a single string and prints out the number of vowels contained in it.

using System;
using System.Linq;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main()
        {
            // a, e, i, o, u, and sometimes y.
            string inpiut = Console.ReadLine().ToLower();

            Console.WriteLine(VowelsCount(inpiut));
        }

        private static int VowelsCount(string inpiut)
        {
            int vowelsCount = 0;
            foreach (var letter in inpiut)
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u' || letter == 'y')
                {
                    vowelsCount++;
                }
            }
            return vowelsCount;
        }
    }
}
