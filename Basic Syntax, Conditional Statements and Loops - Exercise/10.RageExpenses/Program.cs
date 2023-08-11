namespace _10.RageExpenses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            float headsetPrice = float.Parse(Console.ReadLine());
            float mousePrice = float.Parse(Console.ReadLine()); 
            float keyboardPrice = float.Parse(Console.ReadLine());
            float displayPrice = float.Parse(Console.ReadLine());
           
            int headsetSmash = lostGames / 2;
            int  mouseSmash = lostGames / 3;
            int keyboardSmash = lostGames / 6;
            int displaySmash = lostGames / 12;

            float expenses = headsetPrice * headsetSmash + mousePrice * mouseSmash + keyboardPrice * keyboardSmash + displayPrice * displaySmash;

            Console.WriteLine($"Rage expenses: {expenses:f2} lv.");
        }
    }
}