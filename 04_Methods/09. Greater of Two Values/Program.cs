//Create a method, which receives two numbers as parameters:
//•	The first number – the base
//•	The second number – the power
// The method should return the base rase to the given power.

using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputTipe = Console.ReadLine();



            switch (inputTipe)
            {
                case "int":
                    int firstInt = int.Parse(Console.ReadLine());
                    int secondInt = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstInt, secondInt));
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstChar, secondChar));
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    Console.WriteLine(GetMax(firstString, secondString));
                    break;
            }
        }

        static int GetMax(int firstInput, int secondInput)
        {
            if (firstInput > secondInput)
            {
                return firstInput;
            }
            return secondInput;
        }
        static char GetMax(char firstInput, char secondInput)
        {
            if (firstInput > secondInput)
            {
                return firstInput;
            }
            return secondInput;
        }
        static string GetMax(string firstInput, string secondInput)
        {
            int result = firstInput.CompareTo(secondInput);

            if (result > 0)
            {
                return firstInput;
            }
            return secondInput;
        }

    }
}
