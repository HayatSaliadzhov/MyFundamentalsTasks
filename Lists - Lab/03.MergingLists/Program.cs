using System.Reflection.Metadata;

namespace _03.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int>   firstList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
                
            List<int>   secondList = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int biggestList = Math.Max(firstList.Count, secondList.Count);

            for (int i = 0; i < biggestList; i++)
            {
                if (firstList.Count > i)
                {
                    Console.Write(firstList[i] + " ");
                }

                if (secondList.Count > i)
                {
                    Console.Write(secondList[i]+ " ");
                }
            }
        }
    }
}