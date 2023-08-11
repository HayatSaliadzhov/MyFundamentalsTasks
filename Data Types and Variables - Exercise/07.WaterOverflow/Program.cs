using System;
using System.Diagnostics.CodeAnalysis;

namespace _07.WaterOverflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = ushort.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= lines; i++)
            {
                int litres = ushort.Parse(Console.ReadLine());
                int currentLitres = litres;
                sum += litres;
                if (sum > 255)
                {
                    sum -= currentLitres;
                    Console.WriteLine($"Insufficient capacity!");
                }
            }
            Console.WriteLine(sum);

        }
    }
}
