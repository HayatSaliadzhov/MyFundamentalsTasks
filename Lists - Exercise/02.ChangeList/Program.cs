using System.ComponentModel;

namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command = " ";

            while ((command = Console.ReadLine()) != "end")
            {
                string[] commands = command.Split();

                switch (commands[0])
                {
                    case "Delete":
                        int numberToRemove = int.Parse(commands[1]);
                        numbersList.Remove(numberToRemove);
                        break;
                    case "Insert":
                        int number = int.Parse(commands[1]);
                        int index = int.Parse(commands[2]);
                        numbersList.Insert(index, number);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ",numbersList));

        }
    }

    
}