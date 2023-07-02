//Create a program that takes a text and a string of banned words.
//All words included in the ban list should be replaced with asterisks "*", equal to the word's length.
//The entries in the ban list will be separated by a comma and space ", ".
//The ban list should be entered on the first input line and the text on the second input line. 

using System;

namespace _00._Demo
{
    class Program
    {
        string[] wordsToReplace = Console.ReadLine().Split(", ");
        string text = Console.ReadLine();
    }
}
