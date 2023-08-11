using System.Xml.Schema;

namespace _02.VowelsCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            int total = 0;
            PrintVowelsCount(input, total);
        }

        static void PrintVowelsCount(string a, int b)
        {
            int counter = 0;
            string input = Console.ReadLine().ToLower();

            foreach (char vowel in input.ToLower())
            {
                if ("aeiou".Contains(vowel))
                {
                    counter++;
                }   
            }
            
            Console.WriteLine(counter);
        }
    }
}