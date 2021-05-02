using System;

namespace _06.EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int buyers = int.Parse(Console.ReadLine());
            string item = "";

            double basketPrice = 1.50;
            double wreathPrice = 3.80;
            double bunnyPrice = 7.00;

            double totalClientSum = 0;

            

            for (int i = 0; i < buyers; i++)
            {
                double currentClientSum = 0;
                int itemNum = 0;
                while ((item =Console.ReadLine())!="Finish")
                {
                    if (item=="basket")
                    {
                        currentClientSum += basketPrice;
                        itemNum += 1;
                    }
                    else if (item == "wreath")
                    {
                        currentClientSum += wreathPrice;
                        itemNum += 1;
                    }
                    else if (item == "chocolate bunny")
                    {
                        currentClientSum += bunnyPrice;
                        itemNum += 1;
                    }
                }
                if (itemNum%2==0)
                {
                    currentClientSum = currentClientSum * 0.80;
                }
                totalClientSum += currentClientSum;
                Console.WriteLine($"You purchased {itemNum} items for {currentClientSum:F2} leva.");
            }
            double averageSum = totalClientSum / buyers;
            Console.WriteLine($"Average bill per client is: {averageSum:f2} leva.");
        }
    }
}
