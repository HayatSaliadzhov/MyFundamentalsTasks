using System;

namespace _10.MultiplicationTeble
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum = i * n;
                Console.WriteLine($"{n} X {i} = {sum}");
            }
        }
    }
}
