namespace _03.ExactSumOfRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            decimal sum = 0;
           for (int i = 1; i <= num; i++) 
           {
                decimal num1 = decimal.Parse(Console.ReadLine());
                sum += num1;
           }
            Console.WriteLine(sum);
        }
    }
}