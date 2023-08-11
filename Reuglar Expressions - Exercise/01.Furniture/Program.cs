using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace _01.Furniture
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            
            string command;

            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] commands = command.Split("|");
                string operation = commands[0];
                
                switch (operation)
                {
                    case "Move":
                        
                        int number = int.Parse(commands[1]);
                        input = MoveChars(input, number);
                        break;
                    case "Insert":
                        string value = commands[2];
                        int index = int.Parse(commands[1]);
                        input = InsertChars(input, value, index);
                        break;
                    case "ChangeAll":

                        string substring = commands[1];
                        string text = commands[2];
                        input = ChangeAllChars(input, substring, text);
                        break;

                }
            }

            Console.WriteLine($"The decrypted message is: {input}");
        }

        public static string ChangeAllChars(string input, string substring, string replacement)
        {

            var newstring = new StringBuilder();
            newstring.Append(input);
            newstring.Replace(substring, replacement);

            return newstring.ToString();

        }

        public static string InsertChars(string input, string text, int index)
        {
            var sb = new StringBuilder();
            sb.Append(input.Take(index).ToArray());
            sb.Append(text);
            sb.Append(input.Skip(index).ToArray());

            return sb.ToString();

        }

        public static string MoveChars(string text, int index)
        {
            var sb = new StringBuilder();
            sb.Append(text.Skip(index).ToArray());
            sb.Append(text.Take(index).ToArray());

            return sb.ToString();

        }
    }
}