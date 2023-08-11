using System.Xml.Schema;

namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;


            for (int i = 1; i <= n; i++)
            {
                if (isTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool isTopNumber(int num)
        {
            if (isDivisibleByEight(num) && isOddDigit(num))
            {
                return true;
            }
            return false;
        }

        static bool isOddDigit(int number)
        {
            while (number > 0)
            {
                int digit = number % 10;
                number /= 10;
                if (digit % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }

        static bool isDivisibleByEight(int number)
        {
            int sumOfDigits = 0;

            while (number > 0)
            {
                int digit = number % 10;
                sumOfDigits += digit;
                number /= 10;
            }
            return sumOfDigits % 8 == 0;
        }