//Calculate how many courses will be needed to elevate n persons by using an elevator of the capacity of p persons.
//The input holds two lines: the number of people n and the capacity p of the elevator.

using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double courses = Math.Ceiling((double)people / capacity);
            Console.WriteLine(courses);
        }
    }
}
