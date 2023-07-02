//Next, we are going to implement more complicated list commands, extending the previous task.
//Again, read a list and keep reading commands until you receive "end":
//Contains
//{ number} – check if the list contains the number and if so - print "Yes", otherwise print "No such number".
//PrintEven – print all the even numbers, separated by a space.
//PrintOdd – print all the odd numbers, separated by a space.
//GetSum – print the sum of all the numbers.
//Filter {condition} { number} – print all the numbers that fulfill the given condition.
//The condition will be either '<', '>', ">=", "<=".
//After the end command, print the list only if you have made some changes to the original list.
//Changes are made only from the commands from the previous task.

using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> copyOfInput = input.ToList<int>();
            bool isListChanged = false;

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] token = command.Split();
                string action = token[0];

                switch (action)
                {
                    case "Add":
                        copyOfInput.Add(int.Parse(token[1]));
                        isListChanged = true;
                        break;
                    case "Remove":
                        copyOfInput.Remove(int.Parse(token[1]));
                        isListChanged = true;
                        break;
                    case "RemoveAt":
                        copyOfInput.RemoveAt(int.Parse(token[1]));
                        isListChanged = true;
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(token[1]);
                        int indexToInsert = int.Parse(token[2]);
                        copyOfInput.Insert(indexToInsert, numberToInsert);
                        isListChanged = true;
                        break;
                    case "Contains":
                        bool trueActon = input.Contains(int.Parse(token[1]));
                        Console.WriteLine(trueActon ? "Yes" : "No such number");
                        break;
                    case "PrintEven":
                        copyOfInput.RemoveAll(numbers => numbers % 2 != 0);
                        Console.WriteLine(string.Join(' ', copyOfInput));
                        copyOfInput = input.ToList<int>();
                        break;
                    case "PrintOdd":
                        copyOfInput.RemoveAll(numbers => numbers % 2 == 0);
                        Console.WriteLine(string.Join(' ', copyOfInput));
                        copyOfInput = input.ToList<int>();
                        break;
                    case "GetSum":
                        int sumOfNumbersInInput = 0;
                        foreach (var number in input)
                        {
                            sumOfNumbersInInput += number;
                        }
                        Console.WriteLine(sumOfNumbersInInput);
                        break;
                    case "Filter":
                        List<int> anser = FilterCaseAnser(copyOfInput, token);
                        Console.WriteLine(string.Join(' ', anser));
                        break;
                }
                command = Console.ReadLine();
            }
            if (isListChanged)
            {
                Console.WriteLine(string.Join(' ', copyOfInput));
            }
        }

        private static List<int> FilterCaseAnser(List<int> input, string[] token)
        {
            string condition = token[1];
            int number = int.Parse(token[2]);

            List<int> conditionAnser = new List<int>();
            switch (condition)
            {
                case "<":
                    foreach (var curentNumber in input)
                    {
                        if (curentNumber < number)
                        {
                            conditionAnser.Add(curentNumber);
                        }
                    }
                    break;
                case ">":
                    foreach (var curentNumber in input)
                    {
                        if (curentNumber > number)
                        {
                            conditionAnser.Add(curentNumber);
                        }
                    }
                    break;
                case ">=":
                    foreach (var curentNumber in input)
                    {
                        if (curentNumber >= number)
                        {
                            conditionAnser.Add(curentNumber);
                        }
                    }
                    break;
                case "<=":
                    foreach (var curentNumber in input)
                    {
                        if (curentNumber <= number)
                        {
                            conditionAnser.Add(curentNumber);
                        }
                    }
                    break;
            }
            return conditionAnser;
        }
    }
}
