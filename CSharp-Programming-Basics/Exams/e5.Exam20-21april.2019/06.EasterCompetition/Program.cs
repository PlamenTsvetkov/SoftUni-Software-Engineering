using System;

namespace _06.EasterCompetition
{
    class Program
    {
        static void Main(string[] args)
        {
            int easterBredNum = int.Parse(Console.ReadLine());

           
            int grade = 0;
            int maxGrade = 0;            
            string nameBaker = "";
            string nameNumberOne = "";
            string input = "";
            for (int i = 0; i < easterBredNum; i++)
            {
                int sumGrade = 0;
                nameBaker =Console.ReadLine();
                while ((input=Console.ReadLine())!="Stop")
                {
                    grade = int.Parse(input);
                    sumGrade += grade;
                }
                Console.WriteLine($"{nameBaker} has {sumGrade} points.");
                if (maxGrade<sumGrade)
                {
                    maxGrade = sumGrade;
                    nameNumberOne = nameBaker;
                    Console.WriteLine($"{nameNumberOne} is the new number 1!");
                }
            }
            Console.WriteLine($"{nameNumberOne} won competition with {maxGrade} points!");
        }
    }
}
