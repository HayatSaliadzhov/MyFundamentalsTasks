using System.Data;

namespace _06.ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>   numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split();
                switch (tokens[0])
                {
                    case "Add":
                       int numberToAdd = int.Parse(tokens[1]);
                       numbers.Add(numberToAdd);
                        break;
                    case "Remove":
                        int numberToRemove = int.Parse(tokens[1]);
                        numbers.Remove(numberToRemove);
                        break;
                    case "RemoveAt":
                        int removeIndex = int.Parse(tokens[1]);
                        numbers.RemoveAt(removeIndex);
                        break;
                    case "Insert":
                        int insertNumber = int.Parse(tokens[1]);
                        int index = int.Parse(tokens[2]);
                        numbers.Insert(index,insertNumber);
                        break;
                }
            }
            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}