using System;

namespace _01.Advertisement_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(AdvertisementMassage.GenerateMassage());
            }


        }
        public class AdvertisementMassage
        {
           public static string[] Phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product." };
           public static string[] Events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
           public static string[] Authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
           public static string[] Cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            public static string GenerateMassage()
            {
                Random rand = new Random();
                string currentPhrase = Phrases[rand.Next(0, Phrases.Length)];
                string currentEvent = Events[rand.Next(0, Events.Length)];
                string currentAutor = Authors[rand.Next(0, Authors.Length)];
                string currentCity = Cities[rand.Next(0, Cities.Length)];
                return $"{currentPhrase} {currentEvent} {currentAutor} – {currentCity}";
            }

        }
    }
}
