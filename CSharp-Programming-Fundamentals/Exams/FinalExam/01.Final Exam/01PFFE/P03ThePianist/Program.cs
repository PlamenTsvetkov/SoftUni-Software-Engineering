using System;
using System.Collections.Generic;
using System.Linq;

namespace P03ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Piece> pieces = new List<Piece>();
            for (int i = 0; i < n; i++)
            {
                string[] pieceInfo = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string name = pieceInfo[0];
                string composer = pieceInfo[1];
                string key = pieceInfo[2];
                Piece piece = new Piece(name, composer, key);
                pieces.Add(piece);
            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input=="Stop")
                {
                    break;
                }
                string[] allCommand = input.Split("|", StringSplitOptions.RemoveEmptyEntries);
                string command = allCommand[0];
                string name = allCommand[1];
                if (command=="Add")
                {
                    string composer = allCommand[2];
                    string key = allCommand[3];
                    Piece currentPiece = new Piece(name, composer, key);
                    if (pieces.Any(x=>x.Name==name))
                    {
                        Console.WriteLine($"{name} is already in the collection!");
                    }
                    else
                    {
                        pieces.Add(currentPiece);
                        Console.WriteLine($"{name} by {composer} in {key} added to the collection!");
                    }

                }
                else if (command == "Remove")
                {
                    if (pieces.Any(x => x.Name == name))
                    {
                        Piece currentPiece = pieces.FirstOrDefault(x => x.Name == name);
                        Console.WriteLine($"Successfully removed {name}!");
                        pieces.Remove(currentPiece);

                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {name} does not exist in the collection.");
                    }

                }
                else if (command == "ChangeKey")
                {
                    string key = allCommand[2];
                    if (pieces.Any(x => x.Name == name))
                    {
                        Console.WriteLine($"Changed the key of {name} to {key}!");
                        pieces.FirstOrDefault(x => x.Name == name).Key = key;
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {name} does not exist in the collection.");
                    }

                }

            }
            foreach (var piece in pieces.OrderBy(x=>x.Name).ThenBy(x=>x.Composer))
            {
                Console.WriteLine(piece);
            }
        }
        public class Piece
        {
            public Piece(string name , string composer, string key)
            {
                this.Name = name;
                this.Composer = composer;
                this.Key = key;
            }
            public string Name { get; set; }
            public string Composer { get; set; }
            public string Key { get; set; }
            public override string ToString()
            {
                return $"{this.Name} -> Composer: {this.Composer}, Key: {this.Key}";
            }
        }
    }
}
