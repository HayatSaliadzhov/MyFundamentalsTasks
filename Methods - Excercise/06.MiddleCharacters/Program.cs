using System.Runtime.Intrinsics.X86;

namespace _06.MiddleCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = "";
            int a = input.Length / 2;
            char middleChar = input[input.Length / 2];
            if (input.Length % 2 == 0)
            {
               result = input[input.Length / 2 - 1].ToString() + input[input.Length/2].ToString();
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine(middleChar);
            }
        }
    }
}