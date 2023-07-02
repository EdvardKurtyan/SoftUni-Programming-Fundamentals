//Create a program, that reads a list of integers from the console and receives commands to manipulate the list.
//Your program may receive the following commands:
//•	Delete
//{ element} – delete all elements in the array, which are equal to the given element.
//•	Insert {element} { position} – insert the element at the given position.
//You should exit the program when you receive the "end" command.
//Print all numbers in the array separated by a single whitespace.

using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] action = command.Split();
                string instruction = action[0];

                switch (instruction)
                {
                    case "Delete":
                        for (int i = 0; i < input.Count; i++)
                        {
                            if (input[i] == int.Parse(action[1]))
                            {
                                input.Remove(input[i]);
                                i--;
                            }
                        }
                        break;
                    case "Insert":
                        input.Insert(int.Parse(action[2]), int.Parse(action[1]));
                        //input[int.Parse(action[2])] = int.Parse(action[1]);
                        break;
                }

                command = Console.ReadLine();
            }
            foreach (var item in input)
            {
                Console.Write(item + " ");
            }
        }
    }
}
