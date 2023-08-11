namespace _04.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            List<Student> students = new List<Student>();
            while ((command = Console.ReadLine()) != "end")
            {
                string[] tokens = command
                    .Split(" ")
                    .ToArray();
                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);
                string homeTown = tokens[3];
                Student student = new Student(firstName,lastName,age,homeTown);
                students.Add(student);
            }

            string cityName = Console.ReadLine();

            foreach (Student student in students)
            {
                if (student.HomeTown == cityName)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }


    }
}