namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            char opertion = char.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            switch (opertion)
            {
                case '*':
                    Multiply(firstNumber,secondNumber);
                    break;
                case '/':
                    Divide(firstNumber,secondNumber);
                    break;
                case '+':
                    Add(firstNumber,secondNumber);
                    break;
                case '-':
                    Subtract(firstNumber,secondNumber);
                    break;

            }
        }

        static void Multiply(int a, int b)
        {
            Console.WriteLine(a*b);
        }

        static void Subtract(int a, int b)
        {
            Console.WriteLine(a-b);
        }

        static void Add(int a, int b)
        {
            Console.WriteLine(a+b);
        }

        static void Divide(int a, int b)
        {
            Console.WriteLine(a/b);
        }
    }
}