using System.Numerics;

namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long firstFactorial = long.Parse(Console.ReadLine());
            long secondFactorial = long.Parse(Console.ReadLine());

            Console.WriteLine($"{(PrintFactorial(firstFactorial) / PrintFactorial(secondFactorial)):f2}");
        }

        static double PrintFactorial(long number)
        { 
            double total = number;

            for (long i = number - 1; i >= 1; i--)
            {
                total *= i;
            }

            return total;
        }

       
    }
}