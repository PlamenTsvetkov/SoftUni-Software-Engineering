using System;

namespace P01TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string encryptedMassage = Console.ReadLine();
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="Decode")
                {
                    break;
                }
                string[] allCommand = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string command = allCommand[0];
                if (command == "Move")
                {
                    int n = int.Parse(allCommand[1]);

                    string substring = encryptedMassage.Substring(0, n);
                    encryptedMassage = encryptedMassage.Remove(0, n);
                    encryptedMassage = encryptedMassage + substring;
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(allCommand[1]);
                    string value = allCommand[2];
                    encryptedMassage = encryptedMassage.Insert(index, value);
                }
                else if (command == "ChangeAll")
                {
                    string substring = allCommand[1];
                    string replacement = allCommand[2];
                    while (encryptedMassage.Contains(substring))
                    {
                       encryptedMassage= encryptedMassage.Replace(substring, replacement);
                    }
                }
            }
            Console.WriteLine($"The decrypted message is: {encryptedMassage}");
        }
    }
}
