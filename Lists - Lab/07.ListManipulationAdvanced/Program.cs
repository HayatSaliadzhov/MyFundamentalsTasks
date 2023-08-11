namespace _07.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            string command = "";

            while ((command = Console.ReadLine()) != "end")
            {
                string[] commands = command.Split().ToArray();
                switch (commands[0])
                {
                    case "Contains":
                        if (numbers.Contains(int.Parse(commands[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }

                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 1)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                        }

                        Console.WriteLine();
                        break;
                    case "GetSum":
                        Console.WriteLine(numbers.Sum());
                        break;
                    case "Filter":
                        string condition = commands[1];
                        int number1 = int.Parse(commands[2]);

                        if (condition == "<")
                        {
                            foreach (int num in numbers)
                            {
                                if (num < number1)
                                {
                                    Console.WriteLine(num + " ");
                                }
                            }

                            Console.WriteLine();
                        }
                        else if (condition == ">")
                        {
                            foreach (int num in numbers)
                            {
                                if (num > number1)
                                {
                                    Console.Write(num + " ");
                                }
                            }

                            Console.WriteLine();
                        }
                        else if (condition == "<=")
                        {
                            foreach (int num in numbers)
                            {
                                if (num <= number1)
                                {
                                    Console.Write(num + " ");
                                }   
                            }

                            Console.WriteLine();
                        }
                        else if (condition == ">=")
                        {
                            foreach (int num in numbers)
                            {
                                if (num >= number1)
                                {
                                    Console.Write(num + " ");
                                }
                            }

                            Console.WriteLine();
                        }

                        break;

                }
            }
        }
    }
}