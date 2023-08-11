using System;
using System.Linq;

namespace _07.MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] symbols = Console.ReadLine().Split();
            int bestCount = 0;
            string bestSymbol = "";

            for (int i = 0; i < symbols.Length; i++)
            {
                int counter = 0;
                for (int j = i; j < symbols.Length; j++)
                {
                    if (symbols[i] == symbols[j])
                    {
                        counter++;

                        if (bestCount < counter)
                        {
                            
                            bestCount = counter;
                            bestSymbol = symbols[i];
                        }
                        
                    }
                    else
                    {
                        break;
                    }
                }
            }

            for (int i = 0; i < bestCount; i++)
            {
                Console.Write($"{bestSymbol} ");
            }

            
        }
    }
}
  