using System;

namespace _06foreignLanguages
{
    class foreignLanguages
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string language = "";
            if (country == "England" || country == "USA")
            {
                language = "English";
            }
            else if (country == "Spain" || country == "Argentina" || country == "Mexico")
            {
                language = "Spanish";
            }
            else
            {
                language = "unknown";
            }
            Console.WriteLine(language);
        }
    }
}
