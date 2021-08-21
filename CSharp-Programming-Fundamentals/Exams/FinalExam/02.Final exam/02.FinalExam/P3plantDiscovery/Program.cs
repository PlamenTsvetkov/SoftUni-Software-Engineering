using System;
using System.Collections.Generic;
using System.Linq;

namespace P3plantDiscovery
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Plant> plants = new List<Plant>();
            for (int i = 0; i < n; i++)
            {
                string[] plantInfo = Console.ReadLine()
                    .Split("<->", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string currentName = plantInfo[0];
                int currentRarity = int.Parse(plantInfo[1]);
                if (plants.Any(x=>x.Name==currentName))
                {
                    plants.FirstOrDefault(x => x.Name == currentName).Rarity=currentRarity;

                }
                else
                {
                    Plant currentPlant = new Plant(currentName, currentRarity);
                    plants.Add(currentPlant);
                }
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="Exhibition")
                {
                    break;
                }
                string[] allCommand = input
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string command = allCommand[0];
                string[] secondInfo = allCommand[1]
                    .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string currentName = secondInfo[0];
                if (!plants.Any(x => x.Name == currentName))
                {
                    Console.WriteLine("error");
                    continue;
                }

                if (command=="Rate")
                {
                    int currentRaiting = int.Parse(secondInfo[1]);
                        plants.FirstOrDefault(x => x.Name == currentName).Raiting.Add(currentRaiting);
                }
                else if (command == "Update")
                {
                    int currentRarity = int.Parse(secondInfo[1]);
                        plants.FirstOrDefault(x => x.Name == currentName).Rarity=currentRarity;
                }
                else if (command == "Reset")
                {
                        plants.FirstOrDefault(x => x.Name == currentName).Raiting.Clear();
                        plants.FirstOrDefault(x => x.Name == currentName).Raiting.Add(0);
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            Console.WriteLine($"Plants for the exhibition:");
            foreach (var plant in plants.OrderByDescending(x=>x.Rarity).ThenByDescending(x=>x.Raiting.Average()))
            {
                Console.WriteLine(plant);
            }
        }
        public class Plant
        {
            public Plant(string name, int rarity)
            {
                this.Name = name;
                this.Rarity = rarity;
                this.Raiting = new List<int>();

            }
            public string Name { get; set; }
            public int Rarity { get; set; }
            public List<int> Raiting { get; set; }
            public override string ToString()
            {
                return $"- {this.Name}; Rarity: {this.Rarity}; Rating: {Raiting.Average():f2}";
            }
        }
    }
}
