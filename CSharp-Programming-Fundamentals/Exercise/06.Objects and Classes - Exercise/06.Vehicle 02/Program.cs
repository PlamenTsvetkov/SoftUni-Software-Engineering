using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.Vehicle_02
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            while ((input = Console.ReadLine()) != "End")
            {
                List<string> currentVehicle = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                if (currentVehicle[0] == "car")
                {
                    Car car = new Car(currentVehicle[0], currentVehicle[1], currentVehicle[2], double.Parse(currentVehicle[3]));
                    cars.Add(car);
                }
                else if (currentVehicle[0] == "truck")
                {
                    Truck truck = new Truck(currentVehicle[0], currentVehicle[1], currentVehicle[2], double.Parse(currentVehicle[3]));
                    trucks.Add(truck);
                }

            }
            string currentModel = string.Empty;
            while ((currentModel = Console.ReadLine()) != "Close the Catalogue")
            {
                Console.WriteLine(string.Join(Environment.NewLine, cars.Where(model => model.Model == currentModel)));
                Console.WriteLine(string.Join(Environment.NewLine, trucks.Where(model => model.Model == currentModel)));
            }
            Console.WriteLine($"Cars have average horsepower of: {cars.Select(x => x.Horsepower).Average():f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {trucks.Select(x => x.Horsepower).Average():f2}.");
        }
        class Car
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double Horsepower { get; set; }
            public Car(string type, string model, string color, double horsepower)
            {
                this.Type = type;
                this.Model = model;
                this.Color = color;
                this.Horsepower = horsepower;
            }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();


                sb.AppendLine($"Type: {this.Type.First().ToString().ToUpper() + Type.Substring(1)}");
                sb.AppendLine($"Model: {this.Model}");
                sb.AppendLine($"Color: {this.Color}");
                sb.AppendLine($"Horsepower: {this.Horsepower}");
                return sb.ToString().TrimEnd();
            }

        }
        class Truck
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double Horsepower { get; set; }
            public Truck(string type, string model, string color, double horsepower)
            {
                this.Type = type;
                this.Model = model;
                this.Color = color;
                this.Horsepower = horsepower;
            }
            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();


                sb.AppendLine($"Type: {this.Type.First().ToString().ToUpper() + Type.Substring(1)}");
                sb.AppendLine($"Model: {this.Model}");
                sb.AppendLine($"Color: {this.Color}");
                sb.AppendLine($"Horsepower: {this.Horsepower}");
                return sb.ToString().TrimEnd();
            }
        }
    }
}
