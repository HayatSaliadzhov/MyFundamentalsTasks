using System;

namespace _03.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double price = 0;
            double totalprice = 0;

            if (typeOfGroup == "Students")
            {
                switch (dayOfWeek)
                {
                    case "Friday":
                        price = 8.45;
                        break;
                    case "Saturday":
                        price = 9.80;
                        break;
                    case "Sunday":
                        price = 10.46;
                        break;
                }
                totalprice = countOfPeople * price;
                if (countOfPeople >= 30)
                {
                    totalprice = totalprice - totalprice * 0.15;
                }

            }
            else if (typeOfGroup == "Business")
            {
                switch (dayOfWeek)
                {
                    case "Friday":
                        price = 10.90;
                        break;
                    case "Saturday":
                        price = 15.60;
                        break;
                    case "Sunday":
                        price = 16;
                        break;
                }
                totalprice = countOfPeople * price;
                if (countOfPeople >= 100)
                {
                    totalprice = totalprice - (price * 10);
                }
            }
            else if (typeOfGroup == "Regular")
            {
                switch (dayOfWeek)
                {
                    case "Friday":
                        price = 15;
                        break;
                    case "Saturday":
                        price = 20;
                        break;
                    case "Sunday":
                        price = 22.50;
                        break;
                }
                totalprice = countOfPeople * price;
                if (countOfPeople >= 10 && countOfPeople <= 20)
                {
                    totalprice += totalprice * 0.05;
                }
            }
            Console.WriteLine($"Total price: {totalprice:f2}");
            
        }
    }
}
