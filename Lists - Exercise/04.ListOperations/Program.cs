using System.Collections.Specialized;

namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
          List<int> numbers = Console.ReadLine()
              .Split()
              .Select(int.Parse)
              .ToList();
          string command;

          while ((command= Console.ReadLine()) != "End")
          {
              string[] commands = command.Split();

              switch (commands[0])
              {
                    case "Add":
                        int number = int.Parse(commands[1]);
                        numbers.Add(number);
                        break;
                    case "Insert":
                        int index = int.Parse(commands[2]);
                        int num = int.Parse(commands[1]);
                        if (index <= numbers.Count -1  && index >= 0)
                        {
                            numbers.Insert(index, num);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        
                        break;
                    case "Remove":
                        int removeIndex = int.Parse(commands[1]);
                        if (removeIndex <= numbers.Count - 1 && removeIndex >= 0) 
                        {
                            numbers.RemoveAt(removeIndex);
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }
                        
                        break;
                    case "Shift":
                        string direction = commands[1];
                        int repetition = int.Parse(commands[2]);

                            Shift(numbers,direction,repetition);
                        break;

              }
          }

          Console.WriteLine(string.Join(" ",numbers));
        }

        static void Shift(List<int> list, string direction, int count)
        {
            count %= list.Count;

            if (direction == "left")
            {
                List<int> shiftedPart = list.GetRange(0, count);
                list.RemoveRange(0, count);
                list.InsertRange(list.Count, shiftedPart);
            }
            else if (direction == "right")
            {
                List<int> shiftedPart = list.GetRange(list.Count - count, count);
                list.RemoveRange(list.Count - count, count);
                list.InsertRange(0,shiftedPart);
            }

        }
    }
}