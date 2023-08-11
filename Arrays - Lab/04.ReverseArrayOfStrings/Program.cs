using System;
using System.Linq;

namespace _04.ReverseArrayOfStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputs = Console
                .ReadLine()
                .Split(' ')
                .ToArray();
            for (int i = 0; i < inputs.Length / 2; i++)
            {
                var oldInput = inputs[i];
                inputs[i] = inputs[inputs.Length - 1 - i];
                inputs[inputs.Length - 1 - i] = oldInput;
            }

            Console.WriteLine(string.Join(" ", inputs));
        }
    }
}
