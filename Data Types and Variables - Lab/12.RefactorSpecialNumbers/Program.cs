using System;

namespace _12.RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int total = 0;
            int currentNum = 0;
            bool isSpecilNum = false;
            for (int i   = 1; i <= input; i++)
            {
                currentNum = i;
                while (i > 0)
                {
                    total += i % 10;
                    i = i / 10;
                }
                isSpecilNum = (total == 5) || (total == 7) || (total == 11);
                Console.WriteLine($"{currentNum} -> {isSpecilNum}");
                total = 0;
                i = currentNum;
            }
        }
    }
}
