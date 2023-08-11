using System;

namespace _08.BeerKegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int interval = int.Parse(Console.ReadLine());
            double volume = 0;
            double biggestKeg = 0;
            string kegName = string.Empty;

            for (int i = 1; i <= interval; i++)
            {
                string kegModel = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                volume = Math.PI * Math.Pow(radius, 2) * height;
                if (volume > biggestKeg)
                {
                    biggestKeg = volume;
                    kegName = kegModel;
                }
            }

            Console.WriteLine(kegName);

        }
    }
}
