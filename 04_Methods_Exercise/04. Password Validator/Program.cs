//Create a program that checks if a given password is valid.
//The password validation rules are:
//•	It should contain 6 – 10 characters (inclusive)
//•	It should contain only letters and digits
//•	It should contain at least 2 digits 
//If it is not valid, for any unfulfilled rule print the corresponding message:
//•	"Password must be between 6 and 10 characters"
//•	"Password must consist only of letters and digits"
//•	"Password must have at least 2 digits"

using System;
using System.Linq;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            // •	"Password must be between 6 and 10 characters"
            // •	"Password must consist only of letters and digits"
            // •	"Password must have at least 2 digits"

            string password = Console.ReadLine();

            bool passwordLength = PasswordLengthValidate(password);
            bool validPasswordCharacters = CharecterValidate(password);
            bool validDigitCount = DigitCountValidate(password);

            if (!passwordLength)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!validPasswordCharacters)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!validDigitCount)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (passwordLength == true && validPasswordCharacters == true && validDigitCount == true)
            {
                Console.WriteLine("Password is valid");
            }
        }


        private static bool PasswordLengthValidate(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            return false;
        }
        private static bool CharecterValidate(string password)
        {
            foreach (var synbol in password)
            {
                if (!char.IsLetterOrDigit(synbol))
                {
                    return false;
                }
            }
            return true;
        }
        private static bool DigitCountValidate(string password)
        {
            int counter = 0;
            foreach (var sinbol in password)
            {
                if (char.IsDigit(sinbol))
                {
                    counter++;
                }
            }
            return counter >= 2;
        }
    }
}
