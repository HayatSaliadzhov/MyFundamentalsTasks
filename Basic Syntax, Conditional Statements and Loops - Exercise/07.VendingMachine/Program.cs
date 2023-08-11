using System;

namespace _07.VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = string.Empty;
            string product = string.Empty;
            double totalCoins = 0;
            input = Console.ReadLine();
            double nuts = 2;
            double water = 0.7;
            double crisps = 1.5;
            double soda = 0.8;
            double coke = 1;
           
            while (input != "Start")
            {
                
                double coins = double.Parse(input);
                if (coins == 0.1)
                {
                    totalCoins += 0.1;
                }
                else if (coins == 0.2)
                {
                    totalCoins += 0.2;
                }
                else if (coins == 0.5)
                {
                    totalCoins += 0.5;
                }
                else if (coins == 1)
                {
                    totalCoins += 1;
                }
                else if (coins == 2)
                {
                    totalCoins += 2;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coins}");
                }
                
                input = Console.ReadLine();  
            }

            while (input != "End")
            {
                product = Console.ReadLine();
                if (product == "End")
                {
                    break;
                }
                
                if (product == "Nuts")
                {
                    totalCoins -= nuts;
                    if (totalCoins < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        totalCoins += nuts;
                        continue;
                    }
                    Console.WriteLine("Purchased nuts");
                    
                }
                else if (product == "Water")
                {
                    totalCoins -= water;
                    if (totalCoins < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        totalCoins += water;
                        continue;
                    }
                    Console.WriteLine("Purchased water");
                    
                }
                else if (product == "Crisps")
                {
                    totalCoins -= crisps;
                    if (totalCoins < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        totalCoins += crisps;
                        continue;
                    }
                    Console.WriteLine("Purchased crisps");
                    
                }
                else if (product == "Soda")
                {
                    totalCoins -= soda;
                    if (totalCoins < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        totalCoins += soda;
                        continue;
                    }
                    Console.WriteLine("Purchased soda");
                }
                else if (product == "Coke")
                {
                    totalCoins -= coke;
                    if (totalCoins < 0)
                    {
                        Console.WriteLine("Sorry, not enough money");
                        totalCoins += coke;
                        continue;
                    }
                    Console.WriteLine("Purchased coke");
                    
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }                             
            }

            Console.WriteLine($"Change: {totalCoins:f2}");
        }
    }
}

