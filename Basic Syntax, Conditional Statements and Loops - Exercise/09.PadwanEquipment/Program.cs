using System;

namespace _09.PadwanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            float budget = float.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            float lightsaberPrice = float.Parse(Console.ReadLine());
            float robesPrice = float.Parse(Console.ReadLine());
            float beltPrice = float.Parse(Console.ReadLine());
            float totalCosts = 0;
            double sabers = Math.Ceiling(students + students * 0.1);
            double freeBelt = students / 6;
            int saber = Convert.ToInt32(sabers);
            int belt = Convert.ToInt32(freeBelt);
           
            totalCosts = lightsaberPrice * saber + robesPrice * students + beltPrice * (students - belt);


            if (totalCosts <= budget)
            {
                Console.WriteLine($"The money is enough - it would cost {totalCosts:f2}lv.");
            }
            else
            {
                double moneyNeeded = totalCosts - budget;
                Console.WriteLine($"John will need {moneyNeeded:f2}lv more.");
            }
        }
    }
}
