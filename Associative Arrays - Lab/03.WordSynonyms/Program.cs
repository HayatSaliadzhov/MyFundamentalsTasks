namespace _03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfWords = int.Parse(Console.ReadLine());
            var words = new Dictionary<string, List<string>>();
            
            for (int i = 0; i < numberOfWords ; i++)
            {
                string word = Console.ReadLine();
               string synonym = Console.ReadLine();
               if (words.ContainsKey(word))
               {
                   words[word].Add(synonym);
               }
               else
               {
                   words.Add(word, new List<string>(){synonym});
               }
            }

            foreach (var word1 in words)
            {
                Console.WriteLine($"{word1.Key} - {string.Join(", ", word1.Value)}");
            }

        }
    }
}