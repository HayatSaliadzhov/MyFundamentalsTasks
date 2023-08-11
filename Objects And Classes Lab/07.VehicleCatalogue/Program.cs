using Microsoft.VisualBasic;

namespace _07.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();
            Catalog catalog = new Catalog();
            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command
                    .Split("/")
                    .ToArray();
                string type = tokens[0];
                string brand = tokens[1];
                string model = tokens[2];
                string horsePowerOrWeight = tokens[3];
                
                if (type == "Car")
                {
                    Car car = new Car(brand, model, horsePowerOrWeight);
                    catalog.Cars.Add(car);
                }
                else if (type == "Truck")
                {
                    Truck truck  = new Truck(brand, model, horsePowerOrWeight);
                    catalog.Trucks.Add(truck);
                }

            }

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
            }
            foreach ( Car car in catalog.Cars.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            if (catalog.Trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
            }

            foreach (Truck truck in catalog.Trucks.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }

        class Car
        {
            public Car(string brand, string model, string horsePower)
            {
                Brand = brand;
                Model = model;
                HorsePower = horsePower;
            }

            public string Brand { get; set; }
            public string Model { get; set; }
            public string HorsePower { get; set; }
        }

        class Truck
        {
            public Truck(string brand, string model, string weight)
            {
                Brand = brand;
                Model = model;
                Weight = weight;
            }

            public string Brand { get; set; }
            public string Model { get; set; }
            public string Weight { get;set; }
        }

        class Catalog
        {
            public Catalog()
            {
                Cars = new List<Car>();
                Trucks = new List<Truck>();
            }

            public List<Car> Cars { get; set; }
            public List<Truck> Trucks { get; set; }
        }
    }
}