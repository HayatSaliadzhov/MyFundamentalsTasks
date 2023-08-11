using System.Data;

namespace _06.StoreBoxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            List<Box> boxes = new List<Box>();
            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command.Split(" ").ToArray();

                string serialNumber = tokens[0];
                string itemName = tokens[1];
                int itemQuantity = int.Parse(tokens[2]);
                decimal itemPrice = decimal.Parse(tokens[3]);

                Item item = new Item(itemName,itemPrice);
                Box box = new Box(serialNumber, item, itemQuantity);
                boxes.Add(box);
                
            }

            foreach (Box box in boxes.OrderByDescending(x => x.PriceForABox))
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }
        }
    }

    class Item
    {
        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; set; }

        public decimal Price { get; set; }

    }

    class Box
    {
        public Box(string serialNumber, Item item, int quantity)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = quantity;
            
        }

        public string SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public decimal PriceForABox
        {
            get => Item.Price * ItemQuantity;
        }


    }
}