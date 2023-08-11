namespace _01.ghg;
using System.Collections.Generic;
internal class Program
{
    static void Main(string[] args)
    {
        List<double> numbers = Console.ReadLine()
            .Split()
            .Select(double.Parse)
            .ToList();

       int i = 0;
        while ( i < numbers.Count - 1) 
        {
            if (numbers[i] == numbers[i + 1])
            {
                numbers[i] += numbers[i + 1];
                numbers.Remove(numbers[i+1]);
                i = 0;
            }
            else
            {
                i++;
            }
        }

        Console.WriteLine(string.Join(" ", numbers));
    }
}