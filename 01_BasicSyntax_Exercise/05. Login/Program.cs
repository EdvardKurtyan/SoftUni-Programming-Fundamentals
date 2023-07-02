//On the first line, you will be given a username, your task is to try to log in the user.
//The user’s password is username reversed. On the next lines, you will receive passwords:
//•	If the password is incorrect print "Incorrect password. Try again."
//•	If the password is correct print: "User {username} logged in." and stop the program
//Keep in mind, on the fourth attempt if the password is still not correct print: "User {username} blocked!"
//Then the program stops.

using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            string username = Console.ReadLine();
            int usernameLength = username.Length - 1;
            string realPassword = "";

            for (int i = usernameLength; i >= 0; i--)
            {
                realPassword += username[i];
            }

            string password = Console.ReadLine();

            int incorrectPosswordCounter = 0;
            while (password != realPassword)
            {
                incorrectPosswordCounter++;
                Console.WriteLine("Incorrect password. Try again.");
                password = Console.ReadLine();
                if (incorrectPosswordCounter >= 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    return;
                }
            }
            if (password == realPassword)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
