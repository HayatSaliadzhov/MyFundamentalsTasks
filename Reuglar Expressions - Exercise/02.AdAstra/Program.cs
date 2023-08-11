using System.Text.RegularExpressions;

namespace _02.AdAstra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var count = 0;
            string pattern =
                @"(\#|\|)(?<ProductName>[A-Z][a-z]+|[A-z]+ [A-z]+)\1(?<Date>\d{2}\/\d{2}\/\d{2})\1(?<Calories>[0-9]+)\1";

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                count += int.Parse(match.Groups["Calories"].Value);
            }

            Console.WriteLine($"You have food to last you for: {count/2000} days!");
        
        foreach (Match match in matches)
            {
                Console.WriteLine($"Item: {match.Groups["ProductName"].Value}, Best before: {match.Groups["Date"].Value}, Nutrition: {match.Groups["Calories"].Value}");
            }
        }
    }
}