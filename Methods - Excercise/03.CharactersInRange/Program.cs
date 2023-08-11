namespace _03.CharactersInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = ' ';
            char end = ' ';

            PrintCharsInTheRange(start,end);
           
        }

        static void PrintCharsInTheRange(char a, char b)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            if (start < end)
            {
                for (int i = start + 1; i <= end - 1; i++)
                {
                    char code = Convert.ToChar(i);
                    Console.Write($"{code} ");
                }
            }
            else
            {
                for (int i = end + 1; i <= start - 1; i++)
                {
                    char code = Convert.ToChar(i);
                    Console.Write($"{code} ");
                }
            }
            
        }
    }
}