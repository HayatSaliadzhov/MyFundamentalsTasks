using System.Text.RegularExpressions;

/*
 *
 *+359 2 222 2222, 359-2-222-2222, +359/2/222/2222, +359-2 222 2222, +359 2-222-2222, +359-2-222-222, +359-2-222-22222, +359- 2-222-2222
 *
 *
 */

namespace _02.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"\+359(\s|-)2\1\d{3}\1\d{4}\b";

            MatchCollection matches= Regex.Matches(input, pattern);

            Console.WriteLine(string.Join(", ",matches));

        }
    }
}