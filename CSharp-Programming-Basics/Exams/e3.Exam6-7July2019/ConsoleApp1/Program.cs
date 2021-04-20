using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "";
            string mostPowerfulWord = "";
            double maxPower = 0.0;
            double totalSum = 0.0;

            while (word != "End of words")
            {

                word = Console.ReadLine();

                for (int i = 0; i < word.Length; i++)
                {
                    totalSum = word[i];
                }
                int numLength = word.Length;

                string word2 = word.ToLower();
                if ( word2[0] == 'a' || word2[0] == 'e' || word2[0] == 'i' || word2[0] == 'o' || word2[0] == 'u' || word2[0] == 'y')
                {
                    totalSum = totalSum * numLength;
                }
                else
                {
                    totalSum = Math.Floor(totalSum / numLength);
                }
                if (totalSum>maxPower)
                {
                    maxPower = totalSum;
                    mostPowerfulWord = word;
                }
            }
            Console.WriteLine($"The most powerful word is {mostPowerfulWord} - {maxPower}");
        }
    }
}
