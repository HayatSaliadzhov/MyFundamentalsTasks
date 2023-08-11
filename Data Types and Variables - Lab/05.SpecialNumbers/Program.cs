﻿namespace _05.SpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                int number = i;
                int sum = 0;
                while (number != 0)
                {
                    int lastDigit = number % 10;
                    number /= 10;
                    sum += lastDigit; 

                }
                bool isSpeacial = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {isSpeacial}");
            }
        }
    }
}