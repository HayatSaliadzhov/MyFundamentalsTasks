namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
          
            PrintNumbers(n);
        }

        static void PrintNumbers(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int currentNum = i;
                while (currentNum > 0)
                {
                    sum += currentNum % 10;
                    currentNum /= 10;

                    if (sum % 8 == 0 && currentNum == 0 && i % 2 == 1)
                    {
                        Console.WriteLine(i);
                    }
                }
                sum = 0;
            }
        }
    }
}