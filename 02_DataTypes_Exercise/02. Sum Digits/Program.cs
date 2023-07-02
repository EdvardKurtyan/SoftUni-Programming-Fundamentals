//Create a program that receives a single integer. Your task is to find the sum of its digits.
//For example: 12345-> 1 + 2 + 3 + 4 + 5 = 15

using System;

namespace _02._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            string number = Console.ReadLine();
            char[] charArray = number.ToCharArray();
            int sumOfDigits = 0;

            for (int i = 0; i < charArray.Length; i++)
            {
                int curentChar = int.Parse(charArray[i].ToString());
                sumOfDigits += curentChar;
            }
            Console.WriteLine(sumOfDigits);
        }
    }
}
