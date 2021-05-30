using System;

namespace _07.vendingMachine
{
    class vendingMachine
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double totalSum = 0;
            double nutsSum = 2.0;
            double waterSum = 0.7;
            double crispsSum = 1.5;
            double sodaSum = 0.8;
            double cokeSum = 1.0;
            while (input!="Start")
            {
                double coins = double.Parse(input);
                if (coins==0.1)
                {
                    totalSum += coins;
                }
                else if (coins == 0.2)
                {
                    totalSum += coins;
                }
                else if (coins == 0.5)
                {
                    totalSum += coins;
                }
                else if (coins == 1)
                {
                    totalSum += coins;
                }
                else if (coins == 2)
                {
                    totalSum += coins;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                input = Console.ReadLine();
            }
            string input2 = Console.ReadLine();
            while (input2!="End")
            {
                if (input2=="Nuts")
                {
                    if (totalSum>=nutsSum)
                    {
                        totalSum -= nutsSum;
                        Console.WriteLine($"Purchased nuts");
                    }
                    else 
                    {
                        Console.WriteLine($"Sorry, not enough money");
                    }
                }
                else if (input2 == "Water")
                {
                    if (totalSum >= waterSum)
                    {
                        totalSum -= waterSum;
                        Console.WriteLine($"Purchased water");
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, not enough money");
                    }
                }
                else if (input2 == "Crisps")
                {
                    if (totalSum >= crispsSum)
                    {
                        totalSum -= crispsSum;
                        Console.WriteLine($"Purchased crisps");
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, not enough money");
                    }
                }
                else if (input2 == "Soda")
                {
                    if (totalSum >= sodaSum)
                    {
                        totalSum -= sodaSum;
                        Console.WriteLine($"Purchased soda");
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, not enough money");
                    }
                }
                else if (input2 == "Coke")
                {
                    if (totalSum >= cokeSum)
                    {
                        totalSum -= cokeSum;
                        Console.WriteLine($"Purchased coke");
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                input2 = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalSum:f2}");
        }
    }
}
