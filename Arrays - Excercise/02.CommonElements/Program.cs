using System;
using System.Linq;
using System.Net.Mail;

namespace _02.CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firtStrings = Console.ReadLine().Split();
            string[] secondStrings = Console.ReadLine().Split();

            for (int i = 0; i < firtStrings.Length; i++)
            {
                for (int j = 0; j < secondStrings.Length; j++)
                {
                    if (firtStrings[i] == secondStrings[j])
                    {
                        Console.Write($"{firtStrings[i]} ");
                    }
                }
            }

           // foreach (string firstElement in firtStrings)
           // {
            //    foreach (string secondElement in secondStrings)       second solution
             //   {
              //      if (secondElement == firstElement)
              //      {
               //         Console.Write($"{firstElement} ");
              //     }
               // }
            //}
        }
    }
}
