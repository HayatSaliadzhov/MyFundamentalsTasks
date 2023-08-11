using System.Security;

namespace _07.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            PrintRepeatedString(input, n);
        }

        static string PrintRepeatedString(string rep, int count)
        {
            string result = "";
            for (int i = 0; i < count; i++)
            {
                result = rep;
                Console.Write(result);
            }
            return result;
        }
    }
}