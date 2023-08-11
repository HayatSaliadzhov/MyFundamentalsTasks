using System;

namespace _11.MultiplicationTable2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());
            int sum = 0;
            if (multiplier > 10)
            {
                sum = n * multiplier;
                Console.WriteLine($"{n} X {multiplier} = {sum}");
            }
            for (int i = multiplier; i <= 10; i++)
            {
                
                sum = i * n;
                Console.WriteLine($"{n} X {i} = {sum}");
            }
            
        }
    }
}
