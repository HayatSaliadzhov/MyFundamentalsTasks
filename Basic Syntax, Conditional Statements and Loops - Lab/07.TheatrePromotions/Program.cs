using System;

namespace _07.TheatrePromotions
{
    class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int ticketprice = 0;

            switch (day)
            {
                case "Weekday":
                    if (age <=18 && age >= 0)
                    {
                        ticketprice += 12;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        ticketprice += 18;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        ticketprice += 12;
                    }
                    break;
                case "Weekend":
                    if (age <= 18 && age >= 0)
                    {
                        ticketprice += 15;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        ticketprice += 20;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        ticketprice += 15;
                    }
                    break;
                case "Holiday":
                    if (age <= 18 && age >= 0)
                    {
                        ticketprice += 5;
                    }
                    else if (age > 18 && age <= 64)
                    {
                        ticketprice += 12;
                    }
                    else if (age > 64 && age <= 122)
                    {
                        ticketprice += 10;
                    }
                    break;       
            }
            if (age < 0 || age > 122)
            {
                Console.WriteLine("Error!");
                return;
            }
            Console.WriteLine($"{ticketprice}$");

        }
    }
}
