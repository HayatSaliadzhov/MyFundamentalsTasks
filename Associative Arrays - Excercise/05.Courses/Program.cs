using System.Diagnostics;
using System.Xml.Linq;

namespace _05.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, CourseInformation>();
            string input;
            int count = 0;
            while ((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split(" : ");
                string courseName = arguments[0];
                string studentName = arguments[1];
               
                if (!courses.ContainsKey(courseName))
                {
                    CourseInformation course = new CourseInformation(courseName);
                    courses.Add(courseName,course);
                }

                courses[courseName].StudentsNames.Add(studentName);
            }

            foreach (var pair in courses)
            {
                Console.WriteLine(pair.Value);
            }
        }
    }

    class CourseInformation
    {
        public CourseInformation(string name)
        {
            StudentsNames = new List<string>();
            CourseName = name;
        }
        
        public string CourseName { get; set; }

        public List<string> StudentsNames { get; set; }
        public int RegisteredStudents { get; set; }

        public override string ToString()
        {
            string result = $"{CourseName}: {StudentsNames.Count}\n";

            for (int i = 0; i < StudentsNames.Count; i++)
            {
                result += $"-- {StudentsNames[i]}\n";
            }

            return result.Trim();
        }
    }
}