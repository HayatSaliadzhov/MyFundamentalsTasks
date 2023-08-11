namespace _02.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var mine = new Dictionary<string, int>();
            string metal;
            int value;
            while ((metal = Console.ReadLine()) != "stop")
            {  
                
                if (!mine.ContainsKey(metal))
                {
                    mine.Add(metal, 0);
                }
                value = int.Parse(Console.ReadLine());
                mine[metal] += value;
            }

            foreach (var pair in mine)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}