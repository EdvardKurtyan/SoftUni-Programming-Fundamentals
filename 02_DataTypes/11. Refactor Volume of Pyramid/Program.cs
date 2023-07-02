//You are given a working code that finds the volume of a pyramid.
//However, you should consider that the variables exceed their optimum span and have improper naming.
//Also, search for variables that have multiple purposes.

using System;

namespace _11._Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {

            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());

            double volume = (length * width * height) / 3;

            //Reducing the lines of the code whit only one Console.WriteLine();
            Console.WriteLine($"Length: Width: Height: Pyramid Volume: {volume:f2}");
            
            //Length: Width: Height: Pyramid Volume: 9.00
        }
    }
}
