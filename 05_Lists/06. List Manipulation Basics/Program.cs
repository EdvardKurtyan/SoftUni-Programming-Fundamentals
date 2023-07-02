//Write a program that reads a list of integers. Then until you receive "end", you will receive different commands:
//Add
//{ number}: add a number to the end of the list.
//Remove {number}: remove a number from the list.
//RemoveAt {index}: remove a number at a given index.
//Insert {number} { index}: insert a number at a given index.
//Note: All the indices will be valid!
//When you receive the "end" command, print the final state of the list (separated by spaces).

using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            //  o Add { number}: add a number to the end of the list.
            //  o Remove { number}: remove a number from the list.
            //  o RemoveAt { index}: remove a number at a given index.
            //  o Insert { number} { index}: insert a number at a given index.

            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] token = command.Split();
                string action = token[0];

                switch (action)
                {
                    case "Add":
                        input.Add(int.Parse(token[1]));
                        break;
                    case "Remove":
                        input.Remove(int.Parse(token[1]));
                        break;
                    case "RemoveAt":
                        input.RemoveAt(int.Parse(token[1]));
                        break;
                    case "Insert":
                        int numberToInsert = int.Parse(token[1]);
                        int indexToInsert = int.Parse(token[2]);
                        input.Insert(indexToInsert, numberToInsert);
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(' ', input));
        }
    }
}
