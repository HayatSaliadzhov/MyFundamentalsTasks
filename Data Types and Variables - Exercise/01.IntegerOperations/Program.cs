﻿using System;


namespace _01.IntegerOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine()); 
            int secondNum = int.Parse(Console.ReadLine()); 
            int thirdNum = int.Parse(Console.ReadLine()); 
            int fourthNum = int.Parse(Console.ReadLine()); 

            int sum = 0;

            sum = firstNum + secondNum;
            sum /= thirdNum;
            sum *= fourthNum;

            Console.WriteLine(sum);
        }
    }
}


