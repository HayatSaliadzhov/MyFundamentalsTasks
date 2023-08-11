using System;
using System.Linq;
using System.Net;

namespace _08.CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] condensed = new int[numbers.Length];
            bool flag = false;
            for (int i = 0; i < condensed.Length - 1; i++)
            {
                for (int j = 0; j < numbers.Length - 1; j++) 
                {
                    condensed[j] = numbers[j] + numbers[j + 1];
                    flag = true;
                }
                numbers = condensed;
            }

            if (flag == true) 
            {
                Console.WriteLine(condensed[0]);
            }
            if (numbers.Length == 1)
            {
                Console.WriteLine(numbers[0]);
            } 
        }
    }
}
