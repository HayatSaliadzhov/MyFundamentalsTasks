using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.XPath;

namespace _09.GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            switch (input)
            {
                case "int":
                    int firstNumber = int.Parse(Console.ReadLine());
                    int secondNumber = int.Parse(Console.ReadLine());
                    GetMax(firstNumber,secondNumber);
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    GetMax(firstChar,secondChar);
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    GetMax(firstString,secondString);
                    break;
            }
            
                
            

        }

        static int GetMax(int a, int b)
        {
            int result = 0;
            if (a > b)
            {
                result = a;
            }
            else
            {
                result = b;
            }

            Console.WriteLine(result);
            
            return result;
        }

        static char GetMax(char a, char b)
        {
            int result;
            if (a > b)
            {
                result = a;
            }
            else
            {
                result = b;
            }

            Console.WriteLine((char)result);
            return (char)result;

        }

        static string GetMax(string a, string b)
        {
            string result = string.Empty;
            int comparison = a.CompareTo(b);
            
            if (comparison > 0)
            {
                result = a;
                
            }
            else
            {
                result = b;
            }

            Console.WriteLine(result);
            return result;
           
        }
    }
}