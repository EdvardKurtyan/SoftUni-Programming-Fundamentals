//SoftUni just got a new parking lot.It's so fancy, it even has online parking validation.
//Except the online service doesn't work. It can only receive users' data, but it doesn't know what to do with it.
//Good thing you're on the dev team and know how to fix it, right?
//Write a program, which validates a parking place for an online service.Users can register to park and unregister to leave.
//The program receives 2 commands:	
//•	"register {username} {licensePlateNumber}":
//o The system only supports one car per user at the moment, so if a user tries to register another license plate, using the same username, the system should print:
//"ERROR: already registered with plate number {licensePlateNumber}"
//o If the aforementioned checks passes successfully, the plate can be registered, so the system should print:
// "{username} registered {licensePlateNumber} successfully"
//•	"unregister {username}":
//o If the user is not present in the database, the system should print:
//"ERROR: user {username} not found"
//o If the aforementioned check passes successfully, the system should print:
//"{username} unregistered successfully"
//After you execute all of the commands, print all of the currently registered users and their license plates in the format: 
//•	c
//Input
//•	First line: n - number of commands – integer.
//•	Next n lines: commands in one of the two possible formats:
//o Register: "register {username} {licensePlateNumber}"
//o Unregister: "unregister {username}"
//The input will always be valid and you do not need to check it explicitly.

using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            var registeredCars = new Dictionary<string, string>();

            string action = null;
            string ownerName = null;
            string ownerPlate = null;
            for (int i = 0; i < lines; i++)
            {
                string[] input = Console.ReadLine().Split();
                action = input[0];
                ownerName = input[1];
                if (input.Length > 2)
                {
                    ownerPlate = input[2];
                }

                //string[] input = Console.ReadLine().Split();

                switch (action)
                {
                    case "register":
                        if (registeredCars.ContainsKey(ownerName))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {ownerPlate}");
                        }
                        else
                        {
                            Console.WriteLine($"{ownerName} registered {ownerPlate} successfully");
                            registeredCars.Add(ownerName, ownerPlate);
                        }
                        break;
                    case "unregister":
                        if (!registeredCars.ContainsKey(ownerName))
                        {
                            Console.WriteLine($"ERROR: user {ownerName} not found");
                        }
                        else
                        {
                            Console.WriteLine($"{ownerName} unregistered successfully");
                            registeredCars.Remove(ownerName);
                        }
                        break;
                }
            }
            foreach (var car in registeredCars)
            {
                Console.WriteLine($"{car.Key} => {car.Value}");
            }
        }
    }
}
