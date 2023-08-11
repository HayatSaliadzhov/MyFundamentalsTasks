using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            char[] stringArray = username.ToCharArray();
            Array.Reverse(stringArray);
            string revPass = new string(stringArray);
            int passwordCounter = 0;
            while(password != revPass)
            {
                passwordCounter++;
                
                if (passwordCounter > 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                password = Console.ReadLine();
            }
            if (password == revPass)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            
                             
            
        }
    }
}
