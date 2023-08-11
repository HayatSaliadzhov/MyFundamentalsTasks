using System;

namespace _05.PrintPartOfASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
           

            for (int i = startNumber;  i <= endNumber; i++)
            {    
                char code = Convert.ToChar(i);
                Console.Write($"{code} ");
            }
        }
    }
}
