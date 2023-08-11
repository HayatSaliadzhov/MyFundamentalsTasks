﻿using System;
using System.Linq;

namespace _03.RoundingNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console
                .ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();
            int[] roundedNumbers = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                roundedNumbers[i] = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{nums[i]} => {roundedNumbers[i]}");
            }


        }
    }
}
