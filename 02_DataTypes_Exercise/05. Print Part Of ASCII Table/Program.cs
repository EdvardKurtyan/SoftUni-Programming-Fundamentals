//Find online more information about ASCII (American Standard Code for Information Interchange) a
//nd write a program that prints part of the ASCII table of characters at the console.
//On the first line of input, you will receive the char index you should start with,
//and on the second line - the index of the last character you should print.

using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            for (int i = startNum; i <= endNum; i++)
            {
                char curentDigit = (char)i;
                Console.Write($"{curentDigit} ");
            }
        }
    }
}
