using System;

namespace _06.AnaBuilding
{
    class Program
    {
        static void Main(string[] args)
        {
            int countFloor = int.Parse(Console.ReadLine());
            int countRooms = int.Parse(Console.ReadLine());

            for (int f = countFloor; f >= 1; f--)
            {
                for (int r = 0; r < countRooms; r++)
                {
                    if (f==countFloor)
                    {
                        Console.Write($"L{f}{r} ");
                    }
                    else
                    {
                        if (f % 2 == 0)
                        {
                            Console.Write($"O{f}{r} ");
                        }
                        else
                        {
                            Console.Write($"A{f}{r} ");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
