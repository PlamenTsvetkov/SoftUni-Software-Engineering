using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            List<Vehicle> vehicles = new List<Vehicle>();
            while ((input = Console.ReadLine()) != "End")
            {
                List<string> currentVehicle = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToList();
                Vehicle vehicle = new Vehicle(currentVehicle[0], currentVehicle[1], currentVehicle[2], double.Parse(currentVehicle[3]));
                vehicles.Add(vehicle);
            }
            string currentModel = string.Empty;
            while ((currentModel = Console.ReadLine()) != "Close the Catalogue")
            {
                Console.WriteLine(vehicles.FirstOrDefault(x => x.Model == currentModel));

                //Console.WriteLine(string.Join(Environment.NewLine,vehicles.Where(model=>model.Model==currentModel)));
            }
            
            var carsS = vehicles.FindAll(x => x.Type == "car");
            double carsSum = carsS.Sum(x => x.Horsepower);
            double carAverageHorses = carsSum / carsS.Count;
            var truckS = vehicles.FindAll(x => x.Type == "truck");
            double truckSum = truckS.Sum(x => x.Horsepower);
            double truckAverageHorses = truckSum / truckS.Count;

            if (vehicles.FindAll(x => x.Type == "car").Count == 0)
            {
                carAverageHorses = 0;
            }

            if (vehicles.FindAll(x => x.Type == "truck").Count == 0)
            {
                truckAverageHorses = 0;
            }
            Console.WriteLine($"Cars have average horsepower of: {carAverageHorses:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {truckAverageHorses:f2}.");
        }
        class Vehicle
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public double Horsepower { get; set; }
            public Vehicle(string type, string model, string color, double horsepower)
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
