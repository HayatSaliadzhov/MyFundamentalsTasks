﻿using System;

namespace _04.BackIn30Mins
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            minutes += 30;

            if (minutes >= 60)
            {
                hour += 1;
                minutes -= 60;
            }
            if (hour > 23)
            {
                hour = 0;
            }
            Console.WriteLine($"{hour}:{minutes:d2}");
        }
    }
}
