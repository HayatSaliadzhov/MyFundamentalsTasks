using System.ComponentModel;

namespace _03.Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            switch (command)
            {
                case "divide":
                    Divide(a,b);
                    break;
                case "subtract":
                    Subtract(a, b);
                    break;
                case "add":
                    Add(a, b);
                    break;
                case "multiply":
                    Multiply(a, b);
                    break;

            }
        }

        static void Divide(double a, double b)
        { Console.WriteLine(a / b); }
        static void Add(double a, double b)
        { Console.WriteLine(a + b); }
        static void Subtract(double a, double b)
        { Console.WriteLine(a - b); }
        static void Multiply(double a, double b)
        { Console.WriteLine(a * b); }
    }
}