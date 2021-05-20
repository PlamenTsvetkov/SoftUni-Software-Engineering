using System;

namespace _04BackIn30Minutes
{
    class BackIn30Minutes
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int plusMinutes = 30;

            if (minutes+plusMinutes>59)
            {
                if (hour==23)
                {
                    hour = 0;
                    minutes = minutes + 30-60;
                }
                else
                {
                    hour += 1;
                    minutes = minutes + 30 - 60;
                }
            }
            else if (minutes + plusMinutes <= 59)
            {
                minutes += 30;
            }
            Console.WriteLine($"{hour}:{minutes:d2}");
        }
    }
}
