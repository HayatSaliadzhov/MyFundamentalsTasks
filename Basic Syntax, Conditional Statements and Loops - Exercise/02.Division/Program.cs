using System;

namespace _02.Division
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            if (num / 10 % 2 == 0 || num / 10 % 2 == 1)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if (num / 7 % 2 == 0 || num / 7 % 2 == 1)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (num / 6 % 2 == 0 || num/ 6 % 2 == 1)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (num / 3 % 2 == 1 || num / 3 % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (num / 2 % 2 == 0 || num / 2 % 2 == 1)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
        }
    }
}
