//Create a program that keeps track of the guests that are going to a house party.
//On the first line of input, you are going to receive the number of commands that will follow.
//On the next lines, you are going to receive some of the following:  "{name} is going!"
//•	You have to add the person if they are not on the guestlist already.
//•	If the person is on the list print the following to the console: "{name} is already in the list!"
//"{name} is not going!"
//•	You have to remove the person if they are on the list. 
//•	If not, print out: "{name} is not in the list!"
//Finally, print all of the guests, each on a new line.

using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _03._House_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int commandCount = int.Parse(Console.ReadLine());

            var guests = new List<string>();

            for (int i = 0; i < commandCount; i++)
            {
                string[] action = Console.ReadLine().Split();
                string guest = action[0];
                string command = action[1] + action[2];

                switch (command)
                {
                    case "isgoing!":
                        if (!guests.Contains(guest))
                        {
                            guests.Add(guest);
                        }
                        else
                        {
                            Console.WriteLine($"{guest} is already in the list!");
                        }
                        break;
                    case "isnot":
                        if (guests.Contains(guest))
                        {
                            guests.Remove(guest);
                        }
                        else
                        {
                            Console.WriteLine($"{guest} is not in the list!");
                        }
                        break;
                }
            }
            foreach (var guest in guests)
            {
                Console.WriteLine(guest);
            }
        }
    }
}
