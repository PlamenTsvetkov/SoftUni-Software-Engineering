using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();
            while ((input = Console.ReadLine()) != "end")
            {
                List<string> currentItem = input  //{type}/{brand}/{model}/{horse power / weight}
                    .Split("/", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (currentItem[0] == "Truck")
                {
                    Truck truck = new Truck(currentItem[1], currentItem[2], currentItem[3]);
                    trucks.Add(truck);
                }
                else if (currentItem[0] == "Car")
                {
                    Car car = new Car(currentItem[1], currentItem[2], currentItem[3]);
                    cars.Add(car);
                }
            }
            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");
                Console.WriteLine(string.Join(Environment.NewLine, cars.OrderBy(x => x.Brand)));
            }
            if (trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                Console.WriteLine(string.Join(Environment.NewLine, trucks.OrderBy(x => x.Brand)));
            }

        }
        class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Weight { get; set; }
            public Truck(string brand, string model, string weight)
            {
                this.Brand = brand;
                this.Model = model;
                this.Weight = weight;
            }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"{Brand}: {Model} - {Weight}kg");

                return sb.ToString().TrimEnd();
            }
        }
        //        Cars:
        //{Brand}: {Model} - {Horse Power}hp
        //Trucks:
        //{Brand}: {Model} - {Weight}kg

        class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public string Weight { get; set; }
            public Car(string brand, string model, string weight)
            {
                this.Brand = brand;
                this.Model = model;
                this.Weight = weight;
            }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"{Brand}: {Model} - {Weight}hp");

                return sb.ToString().TrimEnd();
            }
        }
    }
}
