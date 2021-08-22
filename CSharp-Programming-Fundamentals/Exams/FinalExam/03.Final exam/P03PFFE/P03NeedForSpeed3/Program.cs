using System;
using System.Collections.Generic;
using System.Linq;

namespace P03NeedForSpeed3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] carInfo = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string name = carInfo[0];
                int mileage = int.Parse(carInfo[1]);
                int fuel = int.Parse(carInfo[2]);
                Car car = new Car(name, mileage, fuel);
                cars.Add(car);
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input =="Stop")
                {
                    break;
                }
                string[] allCommand = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string command = allCommand[0];
                string name = allCommand[1];
                if (command == "Drive")
                {
                    int distance = int.Parse(allCommand[2]);
                    int fuel = int.Parse(allCommand[3]);
                    if (cars.FirstOrDefault(x => x.Name == name).Fuel > fuel)
                    {
                        Console.WriteLine($"{name} driven for {distance} kilometers. {fuel} liters of fuel consumed.");
                        cars.FirstOrDefault(x => x.Name == name).Mileage += distance;
                        cars.FirstOrDefault(x => x.Name == name).Fuel -= fuel;
                    }
                    else
                    {
                        Console.WriteLine($"Not enough fuel to make that ride");
                    }
                    if (cars.FirstOrDefault(x => x.Name == name).Mileage >= 100000)
                    {
                        Console.WriteLine($"Time to sell the {name}!");
                        Car currentCar = cars.FirstOrDefault(x => x.Name == name);
                        cars.Remove(currentCar);
                    }
                }
                else if (command == "Refuel")
                {
                    int fuel = int.Parse(allCommand[2]);
                    if (cars.FirstOrDefault(x => x.Name == name).Fuel + fuel > 75)
                    {
                        int currentCuel = 75 - cars.FirstOrDefault(x => x.Name == name).Fuel;
                        cars.FirstOrDefault(x => x.Name == name).Fuel = 75;
                        Console.WriteLine($"{name} refueled with {currentCuel} liters");

                    }
                    else
                    {
                        cars.FirstOrDefault(x => x.Name == name).Fuel += fuel;
                        Console.WriteLine($"{name} refueled with {fuel} liters");
                    }
                }
                else if (command == "Revert")
                {
                    int km = int.Parse(allCommand[2]);
                    if (cars.FirstOrDefault(x => x.Name == name).Mileage - km < 10000)
                    {
                        cars.FirstOrDefault(x => x.Name == name).Mileage = 10000;

                    }
                    else
                    {
                        cars.FirstOrDefault(x => x.Name == name).Mileage -= km;
                        Console.WriteLine($"{name} mileage decreased by {km} kilometers");
                    }
                }
            }
            foreach (var car in cars.OrderByDescending(x=>x.Mileage).ThenBy(x=>x.Name))
            {
                Console.WriteLine(car);
            }
        }
        public class Car
        {
            public Car(string name , int mileage, int fuel)
            {
                this.Name = name;
                this.Mileage = mileage;
                this.Fuel = fuel;
            }
            public string Name { get; set; }
            public int Mileage { get; set; }
            public int Fuel { get; set; }
            public override string ToString()
            {
                return $"{this.Name} -> Mileage: {this.Mileage} kms, Fuel in the tank: {this.Fuel} lt.";
            }
        }
    }
}
