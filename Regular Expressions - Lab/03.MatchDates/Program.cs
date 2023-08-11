using System.Text.RegularExpressions;

namespace _03.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"(?<Day>\b\d{2})(\.|\/|-)(?<Month>[A-z][a-z]{2})\1(?<Year>\d{4})\b";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["Day"]}, Month: {match.Groups["Month"]}, Year: {match.Groups["Year"]}");
            }
        }
    }
}