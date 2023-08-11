namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int c = 0;
            int total = 0;
            total = SumOfIntegers(a, b) - SubtractIntegers(c);
            Console.WriteLine(total);
        }

        static int SumOfIntegers(int a, int b)
        {
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine()); 
            return a+b;

        }

        static int SubtractIntegers(int c)
        {
            c = int.Parse(Console.ReadLine());
            return c;
        }
    }
}