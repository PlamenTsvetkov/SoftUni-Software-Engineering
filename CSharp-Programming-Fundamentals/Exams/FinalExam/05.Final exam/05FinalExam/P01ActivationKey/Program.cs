using System;

namespace P01ActivationKey
{
    class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            while (true)
            {
                string input = Console.ReadLine();
                if (input=="Generate")
                {
                    break;
                }
                string[] allCommand = input
                    .Split(">>>", StringSplitOptions.RemoveEmptyEntries);
                string command = allCommand[0];
                if (command=="Contains")
                {
                    string substring = allCommand[1];
                    if (activationKey.Contains(substring))
                    {
                        Console.WriteLine($"{activationKey} contains {substring}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command=="Flip")
                {
                    string typeCase = allCommand[1];
                    int startIndex = int.Parse(allCommand[2]);
                    int endIndex = int.Parse(allCommand[3]);
                    int length = endIndex - startIndex ;
                    if (typeCase=="Upper")
                    {

                        string substring = activationKey.Substring(startIndex, length);
                        activationKey = activationKey.Replace(substring, substring.ToString().ToUpper()); 
                    }
                    else if (typeCase=="Lower")
                    {
                        string substring = activationKey.Substring(startIndex, length);
                        activationKey = activationKey.Replace(substring, substring.ToString().ToLower());
                    }
                    Console.WriteLine(activationKey);
                }
                else if (command=="Slice")
                {
                    int startIndex = int.Parse(allCommand[1]);
                    int endIndex = int.Parse(allCommand[2]);
                    int length = endIndex - startIndex;
                    activationKey = activationKey.Remove(startIndex, length);
                    Console.WriteLine(activationKey);
                }
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}
