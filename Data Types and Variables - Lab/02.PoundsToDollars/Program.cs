namespace _02.PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pound = double.Parse(Console.ReadLine());

            double dollars = pound * 1.31;

            Console.WriteLine($"{dollars:f3}");
        }
    }
}