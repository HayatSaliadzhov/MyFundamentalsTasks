namespace _08.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            PrintNumberToPower(number,power);
        }

        static void PrintNumberToPower(double number, int power)
        {
            Console.WriteLine(Math.Pow(number, power));
        }
    }
}