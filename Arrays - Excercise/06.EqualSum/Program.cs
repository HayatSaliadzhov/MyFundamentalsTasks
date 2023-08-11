using System;
using System.Linq;

namespace _06.EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrays = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int leftSum = 0;
            int rightSum = 0;
            int position = 0;
            bool no = true;

            for (int i = 0; i < arrays.Length; i++)
            {
                leftSum = 0;
                for (int l = 0; l < i; l++)
                {
                    leftSum += arrays[l];
                }

                position = i;

                for (int r = i+1; r < arrays.Length; r++)
                {
                    rightSum += arrays[r];
                }

                if (rightSum == leftSum)
                {
                    Console.WriteLine(position);
                    no = false;
                    break;
                }

                rightSum = 0;
                leftSum = 0;
            }

            if (no)
            {
                Console.WriteLine("no");
            }
        }
    }
}
