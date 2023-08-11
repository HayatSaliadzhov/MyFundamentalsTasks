using System;
using System.Linq;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wagonsCount = int.Parse(Console.ReadLine());
            int[] passengers = new int[wagonsCount];

            for (int i = 0; i < passengers.Length; i++)
            {
                int passenger = int.Parse(Console.ReadLine());

                passengers[i] = passenger;
               
            }
            
            Console.WriteLine(string.Join(" ",passengers));
            Console.WriteLine(passengers.Sum());
        }
    }
}
