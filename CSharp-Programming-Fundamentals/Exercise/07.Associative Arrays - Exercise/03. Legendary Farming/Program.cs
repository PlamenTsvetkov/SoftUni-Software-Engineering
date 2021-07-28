using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> keyMaterial = new Dictionary<string, int>();
            keyMaterial.Add("shards", 0);
            keyMaterial.Add("fragments", 0);
            keyMaterial.Add("motes", 0);

            Dictionary<string, int> junkMaterial = new Dictionary<string, int>();
            bool isKeyMaterialLimit = false;
            string firstKeyMatirial = string.Empty;
            while (true)
            {
                List<string> input = Console.ReadLine().ToLower()
                               .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                               .ToList();

                for (int i = 1; i < input.Count; i++)
                {
                    if (input[i] == "shards" || input[i] == "fragments" || input[i] == "motes")
                    {
                        if (keyMaterial.ContainsKey(input[i]))
                        {
                            keyMaterial[input[i]] += int.Parse(input[i - 1]);
                            if (keyMaterial[input[i]] >= 250)
                            {
                                firstKeyMatirial = input[i];
                                isKeyMaterialLimit = true;
                                break;
                            }
                        }


                    }
                    else
                    {
                        if (!junkMaterial.ContainsKey(input[i]))
                        {
                            junkMaterial.Add(input[i], int.Parse(input[i - 1]));
                        }
                        else
                        {
                            junkMaterial[input[i]] += int.Parse(input[i - 1]);
                        }
                    }
                    i++;

                }
                if (isKeyMaterialLimit)
                {
                    break;
                }
            }
            if (firstKeyMatirial == "shards")
            {
                keyMaterial["shards"] -= 250;
                Console.WriteLine("Shadowmourne obtained!");
            }
            else if (firstKeyMatirial == "fragments")
            {
                keyMaterial["fragments"] -= 250;
                Console.WriteLine("Valanyr obtained!");
            }
            else if (firstKeyMatirial == "motes")
            {
                keyMaterial["motes"] -= 250;
                Console.WriteLine("Dragonwrath obtained!");
            }
            foreach (var item in keyMaterial.OrderByDescending(key => key.Value).ThenBy(key => key.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            foreach (var pair in junkMaterial.OrderBy(key => key.Key))
            {
                Console.WriteLine($"{pair.Key}: {pair.Value}");
            }

        }
    }
}
