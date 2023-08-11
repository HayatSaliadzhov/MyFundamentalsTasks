namespace _05.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            double quantityOfProduct = int.Parse(Console.ReadLine());

            switch (product)
            {
                case "coffee":
                    Coffee(quantityOfProduct, 1.50);
                    break;
                case "water":
                    Water(quantityOfProduct, 1.00);
                    break;
                case "coke":
                    Coke(quantityOfProduct, 1.40);
                    break;
                case "snacks":
                    Snacks(quantityOfProduct, 2.00);
                    break;
            }

        }

        static void Coffee(double a, double b)
        {
            Console.WriteLine($"{a*b:f2}");
        }

        static void Water(double a, double b)
        {
            Console.WriteLine($"{a * b:f2}");
        }
        static void Coke(double a, double b)
        { Console.WriteLine($"{a * b:f2}");}

        static void Snacks(double a, double b)
        {
            Console.WriteLine($"{a * b:f2}");
        }
    }
}