namespace _06.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentAcademy = new Dictionary<string, Students>();

            int n = int.Parse(Console.ReadLine());

            string studentName;
            decimal grade;
            for (int i = 0; i < n; i++)
            {
                studentName = Console.ReadLine();
                grade = decimal.Parse(Console.ReadLine());
                
                if (!studentAcademy.ContainsKey(studentName))
                {
                    studentAcademy.Add(studentName,new Students(studentName));
                }

                studentAcademy[studentName].Grade.Add(grade);
                
            }

            IEnumerable<KeyValuePair<string, Students>> filteredStudents =
                studentAcademy.Where(g => g.Value.Grade.Average() >= 4.50m);

            foreach (var  pair in filteredStudents)
            {
                Console.WriteLine(pair.Value);
            }
        }
    }

    class Students
    {
        public Students(string name)
        {
            Name = name;
            Grade = new List<decimal>();
        }

        public string Name { get; set; }
        public List<decimal> Grade { get; set; }
        
        public override string ToString()
        {
            return $"{Name} -> {Grade.Average():F2}";
        }
    }
}