﻿using System.Xml;

namespace _02.Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintGradesResult();
        }

        static void PrintGradesResult()
        {
            double grade = double.Parse(Console.ReadLine());

            if (grade <= 2.99 && grade >= 2)
            {
                Console.WriteLine("Fail");
            }
            else if (grade <= 3.49)
            {
                Console.WriteLine("Poor");
            }
            else if (grade <= 4.49)
            {
                Console.WriteLine("Good");
            }
            else if (grade <= 5.49)
            {
                Console.WriteLine("Very good");
            }
            else if (grade <= 6)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}