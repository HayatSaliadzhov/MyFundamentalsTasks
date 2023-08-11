using System.ComponentModel;

namespace _04.PrintTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            PrintFirstPartOfTriangle(input);
            PrintSecondPartOfTriangle(input);
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintFirstPartOfTriangle(int input)
        {
            for (int i = 1; i <= input; i++)
            {
                PrintLine(1,i);
            }
        }

        static void PrintSecondPartOfTriangle(int input)
        {
            for (int i = input - 1; i >= 1; i--)
            {
               PrintLine(1,i);
            }
        }
    }
}