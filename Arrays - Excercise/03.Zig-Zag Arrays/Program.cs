using System;
using System.Linq;

namespace _03.Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] ints = new int[n];
            int[] ints2 = new int[n];

            for (int i = 0; i < ints.Length; i++)
            {
                int[] inputNum = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                if (i % 2 == 0)
                {
                    ints[i] = inputNum[0];
                    ints2[i] = inputNum[1];
                }
                else
                {
                    ints2[i] = inputNum[0]; 
                    ints[i] = inputNum[1];
                }
            }
            Console.WriteLine(string.Join(" ", ints));
            Console.WriteLine(string.Join(" ", ints2));

        }
    }
}
