using System;

namespace _09.SumOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;
            for (int i = 1; i <= 100; i+=2)
            {
                Console.WriteLine(i);
                sum += i;
                counter++;
                if (counter == n)
                {
                    Console.WriteLine($"Sum: {sum}");
                    break;
                }
                
            }
            
            
        }
    }
}
