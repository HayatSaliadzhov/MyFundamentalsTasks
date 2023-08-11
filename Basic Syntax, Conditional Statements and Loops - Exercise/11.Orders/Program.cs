namespace _11.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal orders = int.Parse(Console.ReadLine());
            decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
            decimal days = int.Parse(Console.ReadLine());
            decimal capsuleCount = int.Parse(Console.ReadLine());

            decimal orderPrice = 0;

            decimal totalCosts = 0;

            for (int i = 1; i <= orders; i++)
            {

                orderPrice = (days * capsuleCount) * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");

                totalCosts += orderPrice;
                if (i == orders)
                {
                    break;
                }
                pricePerCapsule = decimal.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                capsuleCount = int.Parse(Console.ReadLine());                               
            }

            Console.WriteLine($"Total: ${totalCosts:f2}");
        }
    }
}