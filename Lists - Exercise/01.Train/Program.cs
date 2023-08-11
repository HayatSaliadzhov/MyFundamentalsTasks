namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> passengers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int wagonCapacity = int.Parse(Console.ReadLine());
            string command = " ";

            while ((command = Console.ReadLine()) != "end")
            {
                string[] commands = command.Split();

                if (commands[0] == "Add" )
                {
                    int addWagons = int.Parse(commands[1]);
                    passengers.Add(addWagons);
                    continue;
                }

                for (int i = 0; i < passengers.Count; i++)
                {
                    if (passengers[i] <= wagonCapacity)
                    {
                        int addPassengers = int.Parse(commands[0]);
                        passengers[i] += addPassengers;
                        if (passengers[i] > wagonCapacity)
                        {
                            passengers[i] -= addPassengers;
                            continue;
                        }
                        break;
                    }
                    
                }

            }

            Console.WriteLine(string.Join(" ",passengers));

        }
    }
}