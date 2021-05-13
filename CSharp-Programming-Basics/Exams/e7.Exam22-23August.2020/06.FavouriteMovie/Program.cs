using System;

namespace _06.FavouriteMovie
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = "";
            string theBestMovie = "";
            int counter = 0;
            int maxSymvol = int.MinValue;
            while ((movie = Console.ReadLine())!="STOP")
            {
                counter++;
                if (counter>=7)
                {
                    Console.WriteLine("The limit is reached.");
                    break;
                }
                int sumSymvol = 0;
                for (int j = 0; j < movie.Length; j++)
                {
                    if (Char.IsUpper(movie[j]))
                    {
                        sumSymvol += movie[j] - movie.Length;
                    }
                    else if (Char.IsLower(movie[j]))
                    {
                        sumSymvol += movie[j] -(2* movie.Length);
                    }
                    else
                    {
                        sumSymvol += movie[j];
                    }
                }
                if (sumSymvol > maxSymvol)
                {
                    maxSymvol = sumSymvol;
                    theBestMovie = movie;
                }
                
            }
            Console.WriteLine($"The best movie for you is {theBestMovie} with {maxSymvol} ASCII sum.");

        }
    }
}
