namespace test2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "texxxxxxt";

            text = text.Replace("x", "c");

            Console.WriteLine(text);
        }
    }
}