using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace _05.BombNumbersV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> bombNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            numbers = Explode(numbers,bombNumbers);
            Sum(numbers);

        }

        static void Sum(List<int> numbers)
        {
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine(sum);

        }

        static List<int> Explode (List<int> numbers,List<int> bomb)
        {
            int number = bomb[0];
            int power = bomb[1];
            while (numbers.Contains(number))
            {
                int index = numbers.IndexOf(number);

                int leftIndex = Math.Max(0, index - power);
                int rightIndex = Math.Min(numbers.Count - 1, index + power);

                int range = rightIndex - leftIndex + 1;
                numbers.RemoveRange(leftIndex, range);
            }

            return numbers;

        }
    }
}