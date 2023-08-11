namespace _11.RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double volume = 0;
            Console.Write($"Length: ");           
            Console.Write($"Width: ");
            Console.Write($"Height: ");
            
            volume = (length * width * height * 1 / 3);
            Console.WriteLine($"Pyramid Volume: {volume:f2}");
        }
    }
}