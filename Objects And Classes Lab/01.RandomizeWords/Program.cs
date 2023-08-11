namespace _01.RandomizeWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ")
                .ToArray();

            Random random = new Random();

            for (int i = 0; i < input.Length; i++)
            {
                string word = input[i];
               int randomIndex = random.Next(0,input.Length);
               string randomValueAtIndex = input[randomIndex];

                input[i] = randomValueAtIndex;
                input[randomIndex] = word;
            }

            foreach (string random1 in input)
            {
                Console.WriteLine(random1);
            }
        }
    }
}