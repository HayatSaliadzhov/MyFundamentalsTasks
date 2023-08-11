using System;

namespace _04.PrintAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int totalSum = 0;
            for (int i = firstNum; i <= secondNum; i++)
            {
                totalSum += i;
                Console.Write($"{i} ");
                if (secondNum == i)
                {
                    Console.WriteLine("");
                }
            }

            Console.WriteLine($"Sum: {totalSum}");
        }
    }
}
