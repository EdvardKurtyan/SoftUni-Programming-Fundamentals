//Until you receive the "End" command, you will be receiving lines of input in the following format:
//"{typeOfVehicle} {model} {color} {horsepower}"
//When you receive the "End" command, you will start receiving information about some vehicles.
//For every vehicle, print out the information about it in the following format:
//"Type: {typeOfVehicle} Model: {modelOfVehicle} Color: {colorOfVehicle} Horsepower: {horsepowerOfVehicle}"
//When you receive the "Close the Catalogue" command, print out the average horsepower of the cars and the average horsepower of the trucks in the format:
//"{typeOfVehicles} have average horsepower of {averageHorsepower}."
//The average horsepower is calculated by dividing the sum of the horsepower of all vehicles of the given type by the total count of all vehicles from that type. Format the answer to the second digit after the decimal point.
//Constraints
//· The type of vehicle will always be either a car or a truck.
//· You will not receive the same model twice.
//· The received horsepower will be an integer in the range [1…1000].
//· You will receive at most 50 vehicles.
//· The separator will always be single whitespace.

using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        //              Not ready !!!
        static void Main(string[] args)
        {
            List<Car> allCars = new List<Car>();
            List<Truck> allTrucks = new List<Truck>();

            int carCount = 0;
            int truckCount = 0;
            int sumedCarkHorsePower = 0;
            int sumedTruckHorsePower = 0;
            while (true)
            {
                string[] input = Console.ReadLine().Split();
                string command = input[0];
                if (command == "End") break;

                switch (command)
                {
                    case "car":
                        Car car = new Car(input[0], input[1], input[2], int.Parse(input[3]));
                        sumedCarkHorsePower += int.Parse(input[3]);
                        carCount++;
                        allCars.Add(car);
                        break;
                    case "truck":
                        Truck truck = new Truck(input[0], input[1], input[2], int.Parse(input[3]));
                        sumedTruckHorsePower += int.Parse(input[3]);
                        truckCount++;
                        allTrucks.Add(truck);
                        break;
                }
            }
            //PrintingAvarageHorsePowerCars(carCount, sumedCarkHorsePower);
            //PrintingAvarageHorsePowerTrucks(truckCount, sumedTruckHorsePower);

            List<Car> carsToPrint = new List<Car>();
            List<Truck> trucksToPrint = new List<Truck>();

            while (true)
            {
                string model = Console.ReadLine();
                if (model == "Close the Catalogue") break;

                foreach (var car in allCars)
                {
                    if (model == car.Model)
                    {
                        carsToPrint.Add(car);
                    }
                }
                foreach (var truck in allTrucks)
                {
                    if (model == truck.Model)
                    {
                        trucksToPrint.Add(truck);
                    }
                }
            }
            // Type: Car
            // Model: Ferrari
            // Color: red
            // Horsepower: 550

            PrintingCars(carsToPrint);
            PrintingTrucks(trucksToPrint);
            double resultCars = PrintingAvarageHorsePowerCars(carCount, sumedCarkHorsePower);
            double resultTrucks = PrintingAvarageHorsePowerTrucks(truckCount, sumedTruckHorsePower);
            Console.WriteLine($"Cars have average horsepower of: {resultCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {resultTrucks:f2}.");
        }

        private static double PrintingAvarageHorsePowerTrucks(double truckCount, double sumedTruckHorsePower)
        {
            return sumedTruckHorsePower / truckCount;
        }

        private static double PrintingAvarageHorsePowerCars(double carCount, double sumedCarkHorsePower)
        {
            return sumedCarkHorsePower / carCount;
        }

        private static void PrintingTrucks(List<Truck> trucksToPrint)
        {
            foreach (var truck in trucksToPrint)
            {
                Console.WriteLine($"Type: {truck.Type.Substring(0, 1).ToUpper() + truck.Type.Substring(1)}");
                Console.WriteLine($"Model: {truck.Model}");
                Console.WriteLine($"Color: {truck.Color}");
                Console.WriteLine($"Horsepower: {truck.Horsepower}");
            }
        }
        private static void PrintingCars(List<Car> carsToPrint)
        {
            foreach (var car in carsToPrint)
            {
                Console.WriteLine($"Type: {car.Type.Substring(0, 1).ToUpper() + car.Type.Substring(1)}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Color: {car.Color}");
                Console.WriteLine($"Horsepower: {car.Horsepower}");
            }
        }
    }
    class Car
    {
        public Car(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsePower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }
        public int AvarageHorsePower { get; set; }
    }
    class Truck
    {
        public Truck(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            Horsepower = horsePower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }
    }
}

