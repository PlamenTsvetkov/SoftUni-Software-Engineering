using System;

namespace _03
{
    class catLife
    {
        static void Main(string[] args)
        {
            string catBreed = Console.ReadLine();
            char catGender = char.Parse(Console.ReadLine());
            double catAgeYear = 0;
            bool isValid = true;

            if (catBreed== "British Shorthair")
            {
                if (catGender=='m')
                {
                    catAgeYear = 13;
                }
                else
                {
                    catAgeYear = 14;
                }
            }
            else if (catBreed == "Siamese")
            {
                if (catGender == 'm')
                {
                    catAgeYear = 15;
                }
                else
                {
                    catAgeYear = 16;
                }
            }
            else if (catBreed == "Persian")
            {
                if (catGender == 'm')
                {
                    catAgeYear = 14;
                }
                else
                {
                    catAgeYear = 15;
                }
            }
            else if (catBreed == "Ragdoll")
            {
                if (catGender == 'm')
                {
                    catAgeYear = 16;
                }
                else
                {
                    catAgeYear = 17;
                }
            }
            else if (catBreed == "American Shorthair")
            {
                if (catGender == 'm')
                {
                    catAgeYear = 12;
                }
                else
                {
                    catAgeYear = 13;
                }
            }
            else if (catBreed == "Siberian")
            {
                if (catGender == 'm')
                {
                    catAgeYear = 11;
                }
                else
                {
                    catAgeYear = 12;
                }
            }
            else
            {
                isValid = false;
                Console.WriteLine($"{catBreed} is invalid cat!");
            }
            double catAgeHumanMounth = catAgeYear * 12;
            double catAgeCatMounth = catAgeHumanMounth / 6;
            if (isValid)
            {
                Console.WriteLine($"{Math.Floor(catAgeCatMounth)} cat months");
            }
            

        }
    }
}
