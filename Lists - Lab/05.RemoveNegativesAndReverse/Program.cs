namespace _05.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            List<int> newList = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > 0)
                {
                    newList.Add(numbers[i]);
                }
            }

            if (newList.Count != 0)
            {
                newList.Reverse();
                Console.WriteLine(string.Join(" ", newList));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}