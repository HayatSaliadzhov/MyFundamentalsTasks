namespace _01.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var charCount = new Dictionary<char, int>();
            string input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                if (c == ' ')
                {
                    continue;
                }
                if (!charCount.ContainsKey(c))
                {
                    charCount.Add(c, 0);
                }
                charCount[c]++;
            }

            foreach (var pair in charCount)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}