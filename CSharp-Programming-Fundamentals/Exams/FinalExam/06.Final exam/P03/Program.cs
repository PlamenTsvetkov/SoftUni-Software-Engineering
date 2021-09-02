using System;
using System.Collections.Generic;
using System.Linq;

namespace P03
{
    class Program
    {
        static void Main(string[] args)
        {

            List<People> peoples = new List<People>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Results")
                {
                    break;
                }
                string[] peopleInfo = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string command = peopleInfo[0];
                if (command == "Add")
                {
                    string name = peopleInfo[1];
                    int health = int.Parse(peopleInfo[2]);
                    int energy = int.Parse(peopleInfo[3]);
                    if (peoples.Any(x => x.Name == name))
                    {
                        peoples.FirstOrDefault(x => x.Name == name).Health += health;
                        //peoples.FirstOrDefault(x => x.Name == name).Energy += energy;
                    }
                    else
                    {
                        People currentPeople = new People(name, health, energy);
                        peoples.Add(currentPeople);
                    }
                }
                else if (command == "Attack")
                {
                    string attackerName = peopleInfo[1];
                    string deffenderName = peopleInfo[2];
                    int damage = int.Parse(peopleInfo[3]);
                    if (peoples.Any(x => x.Name == attackerName) && peoples.Any(x => x.Name == deffenderName))
                    {
                        peoples.FirstOrDefault(x => x.Name == deffenderName).Health -= damage;
                        if (peoples.FirstOrDefault(x => x.Name == deffenderName).Health <= 0)
                        {
                            People currentDeffender = peoples.FirstOrDefault(x => x.Name == deffenderName);
                            peoples.Remove(currentDeffender);
                            Console.WriteLine($"{deffenderName} was disqualified!");
                        }
                        peoples.FirstOrDefault(x => x.Name == attackerName).Energy -= 1;
                        if (peoples.FirstOrDefault(x => x.Name == attackerName).Energy == 0)
                        {
                            People currentAttacker = peoples.FirstOrDefault(x => x.Name == attackerName);
                            peoples.Remove(currentAttacker);
                            Console.WriteLine($"{attackerName} was disqualified!");
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "Delete")
                {

                    string deleteName = peopleInfo[1];
                    if (deleteName == "All")
                    {
                        peoples.Clear();

                    }
                    else
                    {
                        People currentPeople = peoples.FirstOrDefault(x => x.Name == deleteName);
                        peoples.Remove(currentPeople);
                    }
                }
            }

            Console.WriteLine($"People count: {peoples.Count}");
            foreach (var people in peoples.OrderByDescending(x=>x.Health).ThenBy(x=>x.Name))
            {
                Console.WriteLine(people);
            }
             
        }

        public class People
        {
            public People(string name, int health, int energy)
            {
                this.Name = name;
                this.Health = health;
                this.Energy = energy;
            }
            public string Name { get; set; }
            public int Health { get; set; }
            public int Energy { get; set; }
            public override string ToString()
            {
                return $"{this.Name} - {this.Health} - {this.Energy}";
            }
        }
    }
}
