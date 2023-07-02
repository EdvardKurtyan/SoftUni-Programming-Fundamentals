//Create a program that reads user names on a single line (joined by ", ") and prints all valid usernames. 
//A valid username:
//•	Has length between 3 and 16 characters and
//•	Contains only letters, numbers, hyphens, and underscores

using System;
using System.Collections.Generic;

namespace _01._Valid_Usernames_
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);

            List<string> correctUsernames = new List<string>();

            foreach (var username in usernames)
            {
                if (username.Length >= 3 && username.Length <= 16)
                {
                    bool correctUsername = true;
                    for (int i = 0; i < username.Length; i++)
                    {
                        char curentCharacter = username[i];

                        if (!(curentCharacter == '-' || curentCharacter == '_' || char.IsDigit(curentCharacter)
                            || char.IsLetter(curentCharacter)))
                        {
                            correctUsername = false;
                            break;
                        }
                    }
                    if (correctUsername == true)
                    {
                        correctUsernames.Add(username);
                    }
                }
            }
            foreach (var username in correctUsernames)
            {
                Console.WriteLine(username);
            }
        }
    }
}
