namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employees = new Dictionary<string, Employee>();
            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split(" -> ");
                string companyName = arguments[0];
                string employeeId = arguments[1];

                
                if (!employees.ContainsKey(companyName))
                {
                    Employee employee = new Employee(companyName);
                    
                    employees.Add(companyName,employee);
                }

                if (employees[companyName].IdList.Contains(arguments[1]))
                {
                    continue;
                }
                employees[companyName].IdList.Add(employeeId);

            }

            foreach (var pair in employees)
            {
                Console.WriteLine(pair.Value);
            }
        }
    }

    class Employee
    {
        public Employee(string company)
        {
            Company = company;
            IdList = new List<string>();
        }

        public string Company { get; set;}
        public List<string> IdList { get; set; }

        public override string ToString()
        {
            string result = $"{Company}\n";

            for (int i = 0; i < IdList.Count; i++)
            {
                result += $"-- {IdList[i]}\n";
            }

            return result.Trim();
        }
    }
}