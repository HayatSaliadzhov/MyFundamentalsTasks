using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;
using Microsoft.VisualBasic;

namespace _03.ThePianist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var collectionsPiece = new List<CurrentPieces>();
            Collections(collectionsPiece);
            Operations(collectionsPiece);
            Print(collectionsPiece);

        }

        public static void Print(List<CurrentPieces> collections)
        {

            foreach (var collection in collections)
            {
                Console.WriteLine(collection);
            }
        }

        public static void Operations(List<CurrentPieces> collections)
        {
            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] commands = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
                if (commands[0] == "Add")
                {
                    AddPiece(collections,command);
                }
                else if (commands[0] == "Remove")
                {
                    RemovePiece(collections,command);
                }
                else if (commands[0] == "ChangeKey")
                {
                    ChangeKey(collections,command);
                }
                
                
            }
        }

        public  static void ChangeKey(List<CurrentPieces> collections, string command)
        {
            string[] commandArray = command.Split("|", StringSplitOptions.RemoveEmptyEntries);

            if (collections.Any(x => x.PieceName == commandArray[1]))
            {
                collections.First(x => x.PieceName == commandArray[1]).Key = commandArray[2];
                Console.WriteLine($"Changed the key of {commandArray[1]} to {commandArray[2]}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {commandArray[1]} does not exist in the collection.");
            }

        }

        public static void RemovePiece(List<CurrentPieces> collections, string command)
        {
            string[] commandParts = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
            if (collections.Any(x => x.PieceName == commandParts[1]))
            {
                collections.Remove(collections.First(x => x.PieceName == commandParts[1]));
                Console.WriteLine($"Successfully removed {commandParts[1]}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {commandParts[1]} does not exist in the collection.");
            }

        }

        public static void AddPiece(List<CurrentPieces> collections, string command)
        {
            string[] commandParts = command.Split("|", StringSplitOptions.RemoveEmptyEntries);
            var pieces = new CurrentPieces(commandParts[1], commandParts[2], commandParts[3]);
            if (collections.Any(p => p.PieceName == commandParts[1]))
            {
                Console.WriteLine($"{commandParts[1]} is already in the collection!");
            }
            else
            {
                collections.Add(pieces);
                Console.WriteLine($"{commandParts[1]} by {commandParts[2]} in {commandParts[3]} added to the collection!");
            }
        }

        public static void Collections(List<CurrentPieces> collections)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] collectionStrings = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                var pieces = new CurrentPieces(collectionStrings[0], collectionStrings[1], collectionStrings[2]);
                collections.Add(pieces);
            }
        }
    }


    public class CurrentPieces
    {
        public CurrentPieces(string pieceName, string author, string key)
        {
            PieceName = pieceName;
            Author = author;
            Key = key;
        }

        public string PieceName { get; set; }

        public string Author { get; set; }

        public string Key { get; set; }

        public override string ToString()
        {
            return $"{PieceName} -> Composer: {Author}, Key: {Key}";
        }
    }
}