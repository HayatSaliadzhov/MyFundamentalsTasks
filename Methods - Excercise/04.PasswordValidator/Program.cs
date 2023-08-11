using System.Text.RegularExpressions;

namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            
            bool lengthCheck = PrintPassMustBe6To10(password);
            bool symbolCheck = PrintPassMustConsistLettersAndDigits(password);
            bool twoDigitCheck = PrintPassMustHave2Digits(password);

            if (!lengthCheck)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!symbolCheck)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!twoDigitCheck)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (lengthCheck && symbolCheck && twoDigitCheck)
            {
                Console.WriteLine("Password is valid");
            }
        }

       
        static bool PrintPassMustBe6To10(string password)
        {
            
            if (password.Length < 6 || password.Length > 10)
            {
                return false;
            }

            return true;
        }
        static bool PrintPassMustConsistLettersAndDigits(string password)
        {
            foreach (char symbol in password)
            {
                if (symbol >= 65 && symbol <= 90 ||
                    symbol >= 97 && symbol <= 122 ||
                    symbol >= 48 && symbol <= 57)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            return true;

        }
        static bool PrintPassMustHave2Digits(string password)
        {
            int count = 0;
            foreach (var symbol in password)
            {
                if (symbol >= 48 && symbol <= 57)
                {
                    count++;
                }
            }

            if (count < 2)
            {
                return false;
            }

            return true;
        }

    }
}