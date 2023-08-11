namespace _02.OddOccurrences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split();

            var count = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string wordInLower = word.ToLower();
                if (count.ContainsKey(wordInLower))
                {
                    count[wordInLower]++;
                }
                else
                {
                    count.Add(wordInLower, 1);

                }
            }

            foreach (var count1 in count)
            {
                if (count1.Value % 2 != 0)
                {
                    Console.Write(count1.Key + " ");
                }
            }
        }
    }
}