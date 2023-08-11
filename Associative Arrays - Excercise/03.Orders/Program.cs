namespace _03.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            var products = new Dictionary<string, Products>();

            while ((input = Console.ReadLine()) != "buy")
            {
                string[] arguments = input.Split();

                string name = arguments[0];
                decimal price = decimal.Parse(arguments[1]);
                decimal quantity = decimal.Parse(arguments[2]);

                Products product = new Products(name, price, quantity);
                if (!products.ContainsKey(name))
                {
                    products.Add(name, product);
                }
                else
                {
                    products[name].Update(price,quantity);
                }
            }
            foreach (var productValue in products)
            {
                Console.WriteLine(productValue.Value);
            }
        }
    }


    class Products
    {
        public Products(string name, decimal price, decimal quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }

        public void Update(decimal price, decimal quantity)
        {
            Price = price;
            Quantity += quantity;
        }

        public override string ToString()
        { 
            return $"{Name} -> {Price * Quantity}";
        }
    }
}