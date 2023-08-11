using System.Security;

namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            int number = 0;
            bool isPalindrome = false;
            PrintPalindrome(isPalindrome, number, input);
        }

        static void PrintPalindrome(bool palindromeNumber, int number, string input)
        {
            while ((input = Console.ReadLine())!= "END")
            {
                number = int.Parse(input);
                int reversed = int.Parse(string.Join("", number.ToString().Reverse()));

                if (number == reversed)
                {
                    palindromeNumber = true;
                }
                else
                {
                    palindromeNumber = false;
                }
                Console.WriteLine(palindromeNumber);
            }
           

        }
    }
}