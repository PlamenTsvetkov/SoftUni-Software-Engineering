using System;

namespace _05.AnaCoins
{
    class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            double coin = 0.0;
            double cent = Math.Floor(change * 100);
            
            while (cent > 0)
            {
                if (cent -200>=0)
                {
                    coin += 1;
                    cent -= 200;
                }
                else if  (cent - 100 >= 0)
                    {
                        coin += 1;
                        cent -= 100;
                    }
                else if (cent - 50 >= 0)
                {
                    coin += 1;
                    cent -= 50;
                }
                else if (cent - 20 >= 0)
                {
                    coin += 1;
                    cent -= 20;
                }
                else if (cent - 10 >= 0)
                {
                    coin += 1;
                    cent -= 10;
                }
                else if (cent - 5 >= 0)
                {
                    coin += 1;
                    cent -= 5;
                }
                else if (cent - 2 >= 0)
                {
                    coin += 1;
                    cent -= 2;
                }
                else if (cent - 1 >= 0)
                {
                    coin += 1;
                    cent -= 1;
                }
            }
            Console.WriteLine(coin);
        }
    }
}
