﻿//You will be given an integer that will be a distance in meters.
//Create a program that converts meters to kilometers formatted to the second decimal point.

using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            //V
            double meters = int.Parse(Console.ReadLine());

            double convertedMetersToKilometers = meters / 1000;

            Console.WriteLine($"{convertedMetersToKilometers:f2}");
        }
    }
}
