namespace _04.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, Parking>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] arguments = Console.ReadLine().Split();
                string command = arguments[0];
                string name = arguments[1];
                switch (command)
                {
                    case "register":
                        string licensePlate = arguments[2];
                        Parking park = new Parking(name, licensePlate);
                        if (!users.ContainsKey(name))
                        {
                            users.Add(name,park);
                            Console.WriteLine($"{name} registered {licensePlate} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                        }
                        break;
                    case "unregister":
                        if (users.ContainsKey(name))
                        {
                            users.Remove(name);
                            Console.WriteLine($"{name} unregistered successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {name} not found");
                        }

                        break;
                }
            }

            foreach (var pair in users)
            {
                Console.WriteLine(pair.Value);
            }
        }
    }


    class Parking
    {
        public Parking(string name, string licensePlate)
        {
            Name = name;
            LicensePlate = licensePlate;
        }

        public string Name { get; set; }
        public string LicensePlate { get; set; }

        public override string ToString()
        {
            return $"{Name} => {LicensePlate}";
        }
    }
}