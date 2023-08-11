namespace _01.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNUmber = int.Parse(Console.ReadLine());
            PrintSmallestNumber(firstNumber, secondNumber, thirdNUmber);
        }

        static int PrintSmallestNumber(int a, int b, int c)
        {
            int smallestNumber = 0;
            if (a <= b && a <= c)
            {
                smallestNumber += a;
            }
            else if (a >= b && b <= c)
            {
                smallestNumber += b;
            }
            else if (a >= c && b >= c)
            {
                smallestNumber += c;
            }

            Console.WriteLine(smallestNumber);
            return smallestNumber;
        }
    }
}