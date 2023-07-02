//On the first line, we will receive a list of wagons (integers).
//Each integer represents the number of passengers that are currently in each wagon of a passenger train.
//On the next line, you will receive the max capacity of a wagon represented as a single integer.
//Until you receive the "end" command, you will be receiving two types of input:
//•	Add
//{ passengers} – add a wagon to the end of the train with the given number of passengers.
//•	{passengers} -find a single wagon to fit all the incoming passengers (starting from the first wagon).
//In the end, print the final state of the train (all the wagons separated by a space).

using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] action = command.Split().ToArray();
                string instruction = action[0];

                if (instruction == "Add")
                {
                    wagons.Add(int.Parse(action[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + int.Parse(action[0]) <= maxCapacity)
                        {
                            wagons[i] = wagons[i] + int.Parse(action[0]);
                            break;
                        }
                    }
                }

                command = Console.ReadLine();
            }
            foreach (var wagon in wagons)
            {
                Console.Write($"{wagon} ");
            }
        }
    }
}
