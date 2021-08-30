using System;
using System.Collections.Generic;
using System.Linq;

namespace P3Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<City> cities = new List<City>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="Sail")
                {
                    break;
                }
                string[] citiInfo = input.Split("||", StringSplitOptions.RemoveEmptyEntries);
                string currentName = citiInfo[0];
                int currentPopulation = int.Parse(citiInfo[1]);
                int currentGold = int.Parse(citiInfo[2]);
                if (cities.Any(x=>x.Name==currentName))
                {
                    cities.FirstOrDefault(x => x.Name == currentName).Population += currentPopulation;
                    cities.FirstOrDefault(x => x.Name == currentName).Gold += currentGold;
                }
                else
                {
                    City currentCity = new City(currentName, currentPopulation, currentGold);
                    cities.Add(currentCity);
                }
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                string[] lineInfo = input.Split("=>", StringSplitOptions.RemoveEmptyEntries);
                string command = lineInfo[0];
                string city =lineInfo[1];
                if (command=="Plunder")
                {
                    int people = int.Parse(lineInfo[2]);
                    int gold = int.Parse(lineInfo[3]);
                   
                    cities.FirstOrDefault(x => x.Name == city).Population -= people;
                    cities.FirstOrDefault(x => x.Name == city).Gold -= gold;
                    Console.WriteLine($"{city} plundered! {gold} gold stolen, {people} citizens killed.");
                    if (cities.FirstOrDefault(x => x.Name == city).Population <=0
                        || cities.FirstOrDefault(x => x.Name == city).Gold  <=0 )
                    {
                        Console.WriteLine($"{city} has been wiped off the map!");
                        cities.Remove(cities.FirstOrDefault(x => x.Name == city));
                    }
                }
                else if (command=="Prosper")
                {
                    int gold = int.Parse(lineInfo[2]);
                    if (gold<0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                        continue;
                    }
                    else
                    {
                        cities.FirstOrDefault(x => x.Name == city).Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {city} now has {cities.FirstOrDefault(x => x.Name == city).Gold} gold.");
                        
                    }
                }
            }
            if (cities.Count==0)
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var city in cities.OrderByDescending(x=>x.Gold).ThenBy(x=>x.Name))
                {
                    Console.WriteLine(city);
                }
            }
            }
        public class City
        {
            public City(string name , int population, int gold)
            {
                this.Name = name;
                this.Population = population;
                this.Gold = gold;
            }
            public string Name { get; set; }
            public int Population { get; set; }
            public int Gold { get; set; }
            public override string ToString()
            {
                return $"{this.Name} -> Population: {this.Population} citizens, Gold: {this.Gold} kg";
            }
        }
    }
}
