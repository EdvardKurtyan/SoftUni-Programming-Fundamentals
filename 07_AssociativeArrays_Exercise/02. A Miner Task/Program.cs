//You will be given a sequence of strings, each on a new line.
//Every odd line on the console is representing a resource (e.g. Gold, Silver, Copper and so on) and every even - quantity.
//Your task is to collect the resources and print them each on a new line.
//Print the resources and their quantities in the following format:
//"{resource} –> {quantity}"
//The quantities will be in the range [1… 2 000000000].

using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            var allResources = new Dictionary<string, int>();
            string resource = Console.ReadLine();

            while (resource != "stop")
            {
                int quantity = int.Parse(Console.ReadLine());

                if (!allResources.ContainsKey(resource))
                {
                    allResources.Add(resource, 0);
                }
                allResources[resource] += quantity;

                resource = Console.ReadLine();
            }

            foreach (var item in allResources)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
