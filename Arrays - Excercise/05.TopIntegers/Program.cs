using System;
using System.Linq;

namespace _05.TopIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrays = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int position = 0;
            int num = 0;
            int outputInt = 0;



            for (int i = 0; i < arrays.Length; i++)
            {
               num = arrays[i];

                for (int j = 0 + i; j < arrays.Length; j++)
                {
                    
                    if (num < arrays[j])
                    {
                        position = j;
                        num = arrays[j];
                    }
                }

                if (num != outputInt)
                {
                    outputInt = num;
                    Console.Write($"{outputInt} ");
                }
            }
            
           
           
        }
    }
}
