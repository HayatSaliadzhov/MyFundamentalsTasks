namespace DataTypesAndVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int meters = int.Parse(Console.ReadLine());

            double kilometres = meters / 1000;

            Console.WriteLine($"{kilometres:f2}");
        }
    }
}