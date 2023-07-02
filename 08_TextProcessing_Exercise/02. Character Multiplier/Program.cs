//Create a method that takes two strings as arguments and returns the sum of their character codes multiplied
//(multiply str1[0] with str2[0] and add to the total sum).
//Then continue with the next two characters.
//If one of the strings is longer than the other, add the remaining character codes to the total sum without multiplication.

using System;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string firstWord = input[0];
            string secondWord = input[1];

            Console.WriteLine(CharMultipaier(firstWord, secondWord));
        }

        private static int CharMultipaier(string firstWord, string secondWord)
        {
            int sum = 0;

            int shorterInput = Math.Min(firstWord.Length, secondWord.Length);
            int longesInput = Math.Max(firstWord.Length, secondWord.Length);

            for (int i = 0; i < shorterInput; i++)
            {
                int firstWordCurentDigit = firstWord[i];
                int secondWordCurentDigit = secondWord[i];

                sum += firstWordCurentDigit * secondWordCurentDigit;
            }
            for (int i = shorterInput; i < longesInput; i++)
            {
                if (firstWord.Length == longesInput)
                {
                    sum += firstWord[i];
                }
                else
                {
                    sum += secondWord[i];
                }
            }
            return sum;
        }
    }
}
